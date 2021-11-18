using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Threading;

namespace Soundboard_Client {
    public partial class APIKeyWindow : MaterialForm {
        public APIKeyWindow() {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.Blue400, TextShade.WHITE);
        }

        private void APIKeyWindow_Load(object sender, EventArgs e) {

        }

        private void submitButton_Click(object sender, EventArgs e) {
            Server server = Program.GetServer();

            new Thread(() => {
                bool success = server.Authenticate(apiKeyBox.Text);
                if (success) {
                    Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SoundboardClient", true).SetValue("APIKey", apiKeyBox.Text);
                    MaterialMessageBox.Show("Authentication successfully completed! Please relaunch the application.", false);
                    Environment.Exit(0);
                } else {
                    MaterialMessageBox.Show("Could not verify your API key. You may have provided an invalid key. ", false);
                    submitButton.Enabled = true;
                    apiKeyBox.Enabled = true;
                }
            }).Start();

            submitButton.Enabled = false;
            apiKeyBox.Enabled = false;
        }

        private void apiKeyBox_TextChanged(object sender, EventArgs e) {

        }
    }
}
