using F23.StringSimilarity;
using IWshRuntimeLibrary;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Soundboard_Client {
    public partial class SoundboardForm : MaterialForm {
        private List<string> soundNames = new List<string>();

        public SoundboardForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            string exePath = System.Reflection.Assembly.GetEntryAssembly().Location.Replace(".dll", ".exe");
            string iconRoot = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Soundboard Client";
            string iconPath = iconRoot + "\\icon.ico";
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.Blue400, TextShade.WHITE);

            RefreshSounds(null, null);
            RefreshQueue(null, null);
            System.Timers.Timer timer = new System.Timers.Timer(30000);
            timer.Elapsed += RefreshSounds;
            timer.AutoReset = true;
            timer.Start();

            timer = new System.Timers.Timer(10000);
            timer.Elapsed += RefreshQueue;
            timer.AutoReset = true;
            timer.Start();

            materialSlider1.onValueChanged += UpdateVolume;

            if (System.IO.File.Exists(iconPath + ".temp")) {
                string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Soundboard.lnk";
                System.IO.File.Move(iconPath + ".temp", iconPath, true);

                if (System.IO.File.Exists(shortcutPath)) {
                    System.IO.File.Delete(shortcutPath);
                }

                WshShell wsh = new WshShell();
                IWshShortcut shortcut = wsh.CreateShortcut(shortcutPath) as IWshShortcut;
                shortcut.TargetPath = exePath;
                shortcut.IconLocation = iconPath;
                shortcut.Save();
            }

            if (System.IO.File.Exists(iconPath)) {
                FileStream fs = System.IO.File.OpenRead(iconPath);
                Icon = new Icon(fs);
                fs.Close();
                icoPicture.Image = Image.FromFile(iconPath);
            }
        }

        private void RefreshQueue(Object source, ElapsedEventArgs e) {
            if (source == null || queueListBox.Visible) {
                new Thread(() => {
                    Server server = Program.GetServer();
                    ServerResponse<State> stateResponse = server.getState();

                    if (stateResponse.IsSuccess()) {
                        State state = stateResponse.GetResult();
                        List<string> queue = state.getMusicQueue();
                        int queuePos = 1;

                        queueListBox.Items.Clear();

                        foreach (string queueEntry in queue) {
                            MaterialListBoxItem item = new MaterialListBoxItem(queuePos + ". " + queueEntry);
                            queueListBox.Items.Add(item);
                            queuePos += 1;
                        }

                        nowPlayingLabel.Text = "Now Playing: " + state.getPlayingTrack();
                        materialSlider1.Value = state.getVolume();
                        materialSlider1.Text = "Volume (" + materialSlider1.Value + "/" + materialSlider1.RangeMax + "): ";
                    } else {
                        MaterialMessageBox.Show("Could not get the state of the soundboard bot! Please try again later.");
                    }
                }).Start();
            }
        }

        private void RefreshSounds(Object source, ElapsedEventArgs e) {
            if (source == null || soundList.Visible) {
                new Thread(() => {
                    Server server = Program.GetServer();
                    ServerResponse<List<Sound>> response = server.GetSounds();

                    if (!response.IsSuccess()) {
                        MaterialMessageBox.Show("Could not load the sounds!\nClosing...", false);
                        Environment.Exit(1);
                    }

                    List<Sound> sounds = response.GetResult();
                    List<string> freshSoundNames = new List<string>();

                    foreach (Sound sound in sounds) {
                        freshSoundNames.Add(sound.getName());
                    }

                    if (freshSoundNames.Count == soundNames.Count) {
                        return;
                    }

                    freshSoundNames.Sort();
                    soundNames = freshSoundNames;

                    if (searchBox.Text.Length == 0) {
                        soundList.Items.Clear();

                        foreach (string soundName in soundNames) {
                            MaterialListBoxItem item = new MaterialListBoxItem(soundName);
                            soundList.Items.Add(item);
                        }
                    }
                }).Start();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {
            if (searchBox.Text.Length == 0 && soundList.Items.Count != soundNames.Count) {
                soundList.Items.Clear();

                foreach (string soundName in soundNames) {
                    MaterialListBoxItem item = new MaterialListBoxItem(soundName);
                    soundList.Items.Add(item);
                }
            } else {
                List<string> matchingSounds = new List<string>();

                foreach (string soundName in soundNames) {
                    if (soundName.ToLower().Contains(searchBox.Text.ToLower())) {
                        matchingSounds.Add(soundName);
                    }
                }

                Levenshtein l = new Levenshtein();

                matchingSounds.Sort((a, b) => {
                    return (int)(l.Distance(a.ToLower(), searchBox.Text.ToLower()) - l.Distance(b.ToLower(), searchBox.Text.ToLower()));
                });
                soundList.Items.Clear();

                foreach (string soundName in matchingSounds) {
                    MaterialListBoxItem item = new MaterialListBoxItem(soundName);
                    soundList.Items.Add(item);
                }
            }

            if (soundList.Items.Count > 0) {
                soundList.SelectedIndex = 0;
            }
        }

        private void playButton_Click(object sender, EventArgs e) {
            if (soundList.SelectedItem != null) {
                new Thread(() => {
                    Server server = Program.GetServer();
                    ServerResponse<string> response = server.Play(soundList.SelectedItem.Text);

                    if (!response.IsSuccess()) {
                        MaterialMessageBox.Show("Could not play the sound (Error " + response.getStatusCode() + "): " + response.GetMessage(), false);
                    }
                }).Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e) {
            new Thread(() => {
                Server server = Program.GetServer();
                server.Stop();
            }).Start();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            DialogResult result = MaterialMessageBox.Show("Are you sure that you want to delete this sound?", "Confirm", MessageBoxButtons.YesNo, false);

            if (result == DialogResult.Yes) {
                new Thread(() => {
                    Server server = Program.GetServer();
                    ServerResponse<string> response = server.DeleteSound(soundList.SelectedItem.Text);

                    if (response.IsSuccess()) {
                        MaterialMessageBox.Show("Successfully deleted " + soundList.SelectedItem.Text, false);
                        RefreshSounds(null, null);
                        soundList.SelectedIndex = 0;
                    } else {
                        MaterialMessageBox.Show("Could not delete sound! Please try again later!", false);
                    }
                }).Start();
            }
        }

        private void uploadButton_Click(object sender, EventArgs e) {
            Server server = Program.GetServer();
            string url = videoURLBox.Text;
            string name = soundNameBox.Text;

            videoURLBox.Enabled = false;
            soundNameBox.Enabled = false;
            uploadButton.Enabled = false;

            new Thread(() => {
                ServerResponse<string> response = server.Upload(name, url);

                if (response.IsSuccess()) {
                    MaterialMessageBox.Show("Upload success!", false);
                    RefreshSounds(null, null);
                    soundList.SelectedIndex = 0;
                    videoURLBox.Clear();
                    soundNameBox.Clear();
                } else {
                    MaterialMessageBox.Show("Unable to upload this sound! Please try a different URL.", false);
                }

                videoURLBox.Enabled = true;
                soundNameBox.Enabled = true;
                uploadButton.Enabled = true;
            }).Start();
        }

        private void ttsButton_Click(object sender, EventArgs e) {
            Server server = Program.GetServer();
            string voice = voiceBox.Text;
            string message = ttsMessageBox.Text;

            voiceBox.Enabled = false;
            ttsMessageBox.Enabled = false;
            ttsButton.Enabled = false;

            new Thread(() => {
                server.TTS(voice, message);

                ttsMessageBox.Clear();
                voiceBox.Enabled = true;
                ttsMessageBox.Enabled = true;
                ttsButton.Enabled = true;
            }).Start();
        }

        private void shortcutImageButton_Click(object sender, EventArgs e) {
            DialogResult result = shortcutIconDialog.ShowDialog();

            if (result.Equals(DialogResult.OK)) {
                string path = shortcutIconDialog.FileName;
                string iconRoot = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Soundboard Client";
                string iconPath = iconRoot + "\\icon.ico.temp";

                if (!Directory.Exists(iconRoot)) {
                    Directory.CreateDirectory(iconRoot);
                }

                System.IO.File.Copy(path, iconPath);
                MaterialMessageBox.Show("Done! The application will now restart to apply the changes!", false);
                Environment.Exit(0);
            }
        }

        private void controls_Click(object sender, EventArgs e) {

        }

        private void materialSlider1_Click(object sender, EventArgs e) {

        }


        private void UpdateVolume(object sender, int newValue) {
            Server server = Program.GetServer();
            server.SetVolume(newValue);
            materialSlider1.Text = "Volume (" + newValue + "/" + materialSlider1.RangeMax + "): ";
        }

        private void skipButton_Click(object sender, EventArgs e) {
            Server server = Program.GetServer();

            server.Skip();
            RefreshQueue(null, null);
        }

        private void clearButton_Click(object sender, EventArgs e) {
            Server server = Program.GetServer();

            server.Stop();
            RefreshQueue(null, null);
        }
    }
}
