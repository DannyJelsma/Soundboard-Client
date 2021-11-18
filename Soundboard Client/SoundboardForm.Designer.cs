
namespace Soundboard_Client
{
    partial class SoundboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundboardForm));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.sounds = new System.Windows.Forms.TabPage();
            this.soundList = new MaterialSkin.Controls.MaterialListBox();
            this.searchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.stopButton = new MaterialSkin.Controls.MaterialButton();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.playButton = new MaterialSkin.Controls.MaterialButton();
            this.upload = new System.Windows.Forms.TabPage();
            this.soundNameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.uploadButton = new MaterialSkin.Controls.MaterialButton();
            this.videoURLBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.controls = new System.Windows.Forms.TabPage();
            this.nowPlayingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.clearButton = new MaterialSkin.Controls.MaterialButton();
            this.skipButton = new MaterialSkin.Controls.MaterialButton();
            this.queueListBox = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tts = new System.Windows.Forms.TabPage();
            this.voiceBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.ttsButton = new MaterialSkin.Controls.MaterialButton();
            this.ttsMessageBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.settings = new System.Windows.Forms.TabPage();
            this.icoPicture = new System.Windows.Forms.PictureBox();
            this.shortcutImageButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.shortcutIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.sounds.SuspendLayout();
            this.upload.SuspendLayout();
            this.controls.SuspendLayout();
            this.tts.SuspendLayout();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.sounds);
            this.tabControl.Controls.Add(this.upload);
            this.tabControl.Controls.Add(this.controls);
            this.tabControl.Controls.Add(this.tts);
            this.tabControl.Controls.Add(this.settings);
            this.tabControl.Depth = 0;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(72, 75);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(722, 514);
            this.tabControl.TabIndex = 0;
            // 
            // sounds
            // 
            this.sounds.Controls.Add(this.soundList);
            this.sounds.Controls.Add(this.searchBox);
            this.sounds.Controls.Add(this.stopButton);
            this.sounds.Controls.Add(this.deleteButton);
            this.sounds.Controls.Add(this.playButton);
            this.sounds.ImageKey = "volume-high-dark.png";
            this.sounds.Location = new System.Drawing.Point(4, 24);
            this.sounds.Name = "sounds";
            this.sounds.Padding = new System.Windows.Forms.Padding(3);
            this.sounds.Size = new System.Drawing.Size(714, 486);
            this.sounds.TabIndex = 0;
            this.sounds.Text = "Sounds";
            this.sounds.UseVisualStyleBackColor = true;
            // 
            // soundList
            // 
            this.soundList.BackColor = System.Drawing.Color.White;
            this.soundList.BorderColor = System.Drawing.Color.LightGray;
            this.soundList.Depth = 0;
            this.soundList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soundList.Location = new System.Drawing.Point(7, 45);
            this.soundList.MouseState = MaterialSkin.MouseState.HOVER;
            this.soundList.Name = "soundList";
            this.soundList.SelectedIndex = -1;
            this.soundList.SelectedItem = null;
            this.soundList.Size = new System.Drawing.Size(701, 396);
            this.soundList.TabIndex = 5;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Depth = 0;
            this.searchBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchBox.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("searchBox.LeadingIcon")));
            this.searchBox.Location = new System.Drawing.Point(454, 3);
            this.searchBox.MaxLength = 100;
            this.searchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(257, 36);
            this.searchBox.TabIndex = 4;
            this.searchBox.Text = "";
            this.searchBox.TrailingIcon = null;
            this.searchBox.UseTallSize = false;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // stopButton
            // 
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.stopButton.Depth = 0;
            this.stopButton.HighEmphasis = true;
            this.stopButton.Icon = null;
            this.stopButton.Location = new System.Drawing.Point(571, 450);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(64, 36);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stopButton.UseAccentColor = false;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(7, 450);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 36);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // playButton
            // 
            this.playButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.playButton.Depth = 0;
            this.playButton.HighEmphasis = true;
            this.playButton.Icon = null;
            this.playButton.Location = new System.Drawing.Point(643, 450);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.playButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(64, 36);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.playButton.UseAccentColor = false;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // upload
            // 
            this.upload.Controls.Add(this.soundNameBox);
            this.upload.Controls.Add(this.materialLabel2);
            this.upload.Controls.Add(this.uploadButton);
            this.upload.Controls.Add(this.videoURLBox);
            this.upload.Controls.Add(this.materialLabel1);
            this.upload.ImageKey = "upload.png";
            this.upload.Location = new System.Drawing.Point(4, 24);
            this.upload.Name = "upload";
            this.upload.Padding = new System.Windows.Forms.Padding(3);
            this.upload.Size = new System.Drawing.Size(714, 486);
            this.upload.TabIndex = 1;
            this.upload.Text = "Upload Sounds";
            this.upload.UseVisualStyleBackColor = true;
            // 
            // soundNameBox
            // 
            this.soundNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soundNameBox.Depth = 0;
            this.soundNameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.soundNameBox.LeadingIcon = null;
            this.soundNameBox.Location = new System.Drawing.Point(6, 28);
            this.soundNameBox.MaxLength = 255;
            this.soundNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.soundNameBox.Multiline = false;
            this.soundNameBox.Name = "soundNameBox";
            this.soundNameBox.Size = new System.Drawing.Size(701, 36);
            this.soundNameBox.TabIndex = 4;
            this.soundNameBox.Text = "";
            this.soundNameBox.TrailingIcon = null;
            this.soundNameBox.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 5);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(97, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Sound Name:";
            // 
            // uploadButton
            // 
            this.uploadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uploadButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.uploadButton.Depth = 0;
            this.uploadButton.HighEmphasis = true;
            this.uploadButton.Icon = null;
            this.uploadButton.Location = new System.Drawing.Point(577, 450);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uploadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(130, 36);
            this.uploadButton.TabIndex = 2;
            this.uploadButton.Text = "Upload Sound";
            this.uploadButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.uploadButton.UseAccentColor = false;
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // videoURLBox
            // 
            this.videoURLBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.videoURLBox.Depth = 0;
            this.videoURLBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.videoURLBox.LeadingIcon = null;
            this.videoURLBox.Location = new System.Drawing.Point(6, 122);
            this.videoURLBox.MaxLength = 2000;
            this.videoURLBox.MouseState = MaterialSkin.MouseState.OUT;
            this.videoURLBox.Multiline = false;
            this.videoURLBox.Name = "videoURLBox";
            this.videoURLBox.Size = new System.Drawing.Size(701, 36);
            this.videoURLBox.TabIndex = 1;
            this.videoURLBox.Text = "";
            this.videoURLBox.TrailingIcon = null;
            this.videoURLBox.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Video URL:";
            // 
            // controls
            // 
            this.controls.Controls.Add(this.nowPlayingLabel);
            this.controls.Controls.Add(this.materialSlider1);
            this.controls.Controls.Add(this.clearButton);
            this.controls.Controls.Add(this.skipButton);
            this.controls.Controls.Add(this.queueListBox);
            this.controls.Controls.Add(this.materialLabel6);
            this.controls.ImageKey = "play.png";
            this.controls.Location = new System.Drawing.Point(4, 24);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(714, 486);
            this.controls.TabIndex = 4;
            this.controls.Text = "Controls";
            this.controls.UseVisualStyleBackColor = true;
            this.controls.Click += new System.EventHandler(this.controls_Click);
            // 
            // nowPlayingLabel
            // 
            this.nowPlayingLabel.AutoSize = true;
            this.nowPlayingLabel.Depth = 0;
            this.nowPlayingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nowPlayingLabel.Location = new System.Drawing.Point(3, 1);
            this.nowPlayingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nowPlayingLabel.Name = "nowPlayingLabel";
            this.nowPlayingLabel.Size = new System.Drawing.Size(154, 19);
            this.nowPlayingLabel.TabIndex = 5;
            this.nowPlayingLabel.Text = "Now Playing: Nothing";
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(4, 451);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 200;
            this.materialSlider1.Size = new System.Drawing.Size(549, 40);
            this.materialSlider1.TabIndex = 4;
            this.materialSlider1.Text = "Volume (0/200):";
            this.materialSlider1.UseAccentColor = true;
            this.materialSlider1.Value = 100;
            this.materialSlider1.ValueMax = 200;
            this.materialSlider1.Click += new System.EventHandler(this.materialSlider1_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearButton.Depth = 0;
            this.clearButton.HighEmphasis = true;
            this.clearButton.Icon = null;
            this.clearButton.Location = new System.Drawing.Point(644, 451);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 36);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearButton.UseAccentColor = false;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.skipButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.skipButton.Depth = 0;
            this.skipButton.HighEmphasis = true;
            this.skipButton.Icon = null;
            this.skipButton.Location = new System.Drawing.Point(572, 451);
            this.skipButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.skipButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(64, 36);
            this.skipButton.TabIndex = 2;
            this.skipButton.Text = "Skip";
            this.skipButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.skipButton.UseAccentColor = false;
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // queueListBox
            // 
            this.queueListBox.BackColor = System.Drawing.Color.White;
            this.queueListBox.BorderColor = System.Drawing.Color.LightGray;
            this.queueListBox.Depth = 0;
            this.queueListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.queueListBox.Location = new System.Drawing.Point(4, 58);
            this.queueListBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.SelectedIndex = -1;
            this.queueListBox.SelectedItem = null;
            this.queueListBox.Size = new System.Drawing.Size(706, 387);
            this.queueListBox.TabIndex = 1;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(3, 36);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(46, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Queue";
            // 
            // tts
            // 
            this.tts.Controls.Add(this.voiceBox);
            this.tts.Controls.Add(this.materialLabel4);
            this.tts.Controls.Add(this.ttsButton);
            this.tts.Controls.Add(this.ttsMessageBox);
            this.tts.Controls.Add(this.materialLabel3);
            this.tts.ImageKey = "account-voice.png";
            this.tts.Location = new System.Drawing.Point(4, 24);
            this.tts.Name = "tts";
            this.tts.Size = new System.Drawing.Size(714, 486);
            this.tts.TabIndex = 2;
            this.tts.Text = "TTS";
            this.tts.UseVisualStyleBackColor = true;
            // 
            // voiceBox
            // 
            this.voiceBox.AutoResize = false;
            this.voiceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.voiceBox.Depth = 0;
            this.voiceBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.voiceBox.DropDownHeight = 118;
            this.voiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voiceBox.DropDownWidth = 121;
            this.voiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.voiceBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.voiceBox.FormattingEnabled = true;
            this.voiceBox.IntegralHeight = false;
            this.voiceBox.ItemHeight = 29;
            this.voiceBox.Items.AddRange(new object[] {
            "Brian",
            "Ivy",
            "Justin",
            "Russell",
            "Nicole",
            "Emma",
            "Amy",
            "Joanna",
            "Salli",
            "Kimberly",
            "Kendra",
            "Joey",
            "Mizuki",
            "Chantal",
            "Mathieu",
            "Maxim",
            "Hans",
            "Raveena"});
            this.voiceBox.Location = new System.Drawing.Point(4, 27);
            this.voiceBox.MaxDropDownItems = 4;
            this.voiceBox.MouseState = MaterialSkin.MouseState.OUT;
            this.voiceBox.Name = "voiceBox";
            this.voiceBox.Size = new System.Drawing.Size(121, 35);
            this.voiceBox.StartIndex = 0;
            this.voiceBox.TabIndex = 5;
            this.voiceBox.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(3, 4);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(44, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Voice:";
            // 
            // ttsButton
            // 
            this.ttsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ttsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ttsButton.Depth = 0;
            this.ttsButton.HighEmphasis = true;
            this.ttsButton.Icon = null;
            this.ttsButton.Location = new System.Drawing.Point(621, 448);
            this.ttsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ttsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ttsButton.Name = "ttsButton";
            this.ttsButton.Size = new System.Drawing.Size(89, 36);
            this.ttsButton.TabIndex = 3;
            this.ttsButton.Text = "Send TTS";
            this.ttsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ttsButton.UseAccentColor = false;
            this.ttsButton.UseVisualStyleBackColor = true;
            this.ttsButton.Click += new System.EventHandler(this.ttsButton_Click);
            // 
            // ttsMessageBox
            // 
            this.ttsMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttsMessageBox.Depth = 0;
            this.ttsMessageBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ttsMessageBox.LeadingIcon = null;
            this.ttsMessageBox.Location = new System.Drawing.Point(4, 111);
            this.ttsMessageBox.MaxLength = 99999;
            this.ttsMessageBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ttsMessageBox.Multiline = false;
            this.ttsMessageBox.Name = "ttsMessageBox";
            this.ttsMessageBox.Size = new System.Drawing.Size(706, 36);
            this.ttsMessageBox.TabIndex = 1;
            this.ttsMessageBox.Text = "";
            this.ttsMessageBox.TrailingIcon = null;
            this.ttsMessageBox.UseTallSize = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(3, 87);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(103, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "TTS Message:";
            // 
            // settings
            // 
            this.settings.Controls.Add(this.icoPicture);
            this.settings.Controls.Add(this.shortcutImageButton);
            this.settings.Controls.Add(this.materialLabel5);
            this.settings.ImageKey = "cog.png";
            this.settings.Location = new System.Drawing.Point(4, 24);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(714, 486);
            this.settings.TabIndex = 3;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // icoPicture
            // 
            this.icoPicture.Location = new System.Drawing.Point(176, 17);
            this.icoPicture.Name = "icoPicture";
            this.icoPicture.Size = new System.Drawing.Size(48, 48);
            this.icoPicture.TabIndex = 2;
            this.icoPicture.TabStop = false;
            // 
            // shortcutImageButton
            // 
            this.shortcutImageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shortcutImageButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.shortcutImageButton.Depth = 0;
            this.shortcutImageButton.HighEmphasis = true;
            this.shortcutImageButton.Icon = null;
            this.shortcutImageButton.Location = new System.Drawing.Point(4, 29);
            this.shortcutImageButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.shortcutImageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.shortcutImageButton.Name = "shortcutImageButton";
            this.shortcutImageButton.Size = new System.Drawing.Size(123, 36);
            this.shortcutImageButton.TabIndex = 1;
            this.shortcutImageButton.Text = "Select Image";
            this.shortcutImageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.shortcutImageButton.UseAccentColor = false;
            this.shortcutImageButton.UseVisualStyleBackColor = true;
            this.shortcutImageButton.Click += new System.EventHandler(this.shortcutImageButton_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(4, 4);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(153, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Set Icon (48x48, .ico):";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "volume-high-dark.png");
            this.imageList1.Images.SetKeyName(1, "upload.png");
            this.imageList1.Images.SetKeyName(2, "account-voice.png");
            this.imageList1.Images.SetKeyName(3, "cog.png");
            this.imageList1.Images.SetKeyName(4, "play.png");
            // 
            // shortcutIconDialog
            // 
            this.shortcutIconDialog.DefaultExt = "ico";
            // 
            // SoundboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.tabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.Name = "SoundboardForm";
            this.Padding = new System.Windows.Forms.Padding(0, 72, 3, 3);
            this.Sizable = false;
            this.Text = "Soundboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.sounds.ResumeLayout(false);
            this.sounds.PerformLayout();
            this.upload.ResumeLayout(false);
            this.upload.PerformLayout();
            this.controls.ResumeLayout(false);
            this.controls.PerformLayout();
            this.tts.ResumeLayout(false);
            this.tts.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage sounds;
        private System.Windows.Forms.TabPage upload;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialButton playButton;
        private MaterialSkin.Controls.MaterialButton stopButton;
        private MaterialSkin.Controls.MaterialTextBox searchBox;
        private MaterialSkin.Controls.MaterialTextBox videoURLBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton uploadButton;
        private MaterialSkin.Controls.MaterialTextBox soundNameBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListBox soundList;
        private System.Windows.Forms.TabPage tts;
        private MaterialSkin.Controls.MaterialTextBox ttsMessageBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox voiceBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton ttsButton;
        private System.Windows.Forms.TabPage settings;
        private MaterialSkin.Controls.MaterialButton shortcutImageButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.OpenFileDialog shortcutIconDialog;
        private System.Windows.Forms.PictureBox icoPicture;
        private System.Windows.Forms.TabPage controls;
        private MaterialSkin.Controls.MaterialButton clearButton;
        private MaterialSkin.Controls.MaterialButton skipButton;
        private MaterialSkin.Controls.MaterialListBox queueListBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialLabel nowPlayingLabel;
    }
}

