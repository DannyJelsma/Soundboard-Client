
namespace Soundboard_Client
{
    partial class APIKeyWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.apiKeyBox = new MaterialSkin.Controls.MaterialTextBox();
            this.submitButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(184, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Please enter your API Key:";
            // 
            // apiKeyBox
            // 
            this.apiKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apiKeyBox.Depth = 0;
            this.apiKeyBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.apiKeyBox.LeadingIcon = null;
            this.apiKeyBox.Location = new System.Drawing.Point(17, 100);
            this.apiKeyBox.MaxLength = 255;
            this.apiKeyBox.MouseState = MaterialSkin.MouseState.OUT;
            this.apiKeyBox.Multiline = false;
            this.apiKeyBox.Name = "apiKeyBox";
            this.apiKeyBox.Size = new System.Drawing.Size(365, 36);
            this.apiKeyBox.TabIndex = 1;
            this.apiKeyBox.Text = "";
            this.apiKeyBox.TrailingIcon = null;
            this.apiKeyBox.UseTallSize = false;
            this.apiKeyBox.TextChanged += new System.EventHandler(this.apiKeyBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitButton.Depth = 0;
            this.submitButton.HighEmphasis = true;
            this.submitButton.Icon = null;
            this.submitButton.Location = new System.Drawing.Point(17, 145);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 36);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitButton.UseAccentColor = false;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // APIKeyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 193);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.apiKeyBox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "APIKeyWindow";
            this.Text = "APIKeyWindow";
            this.Load += new System.EventHandler(this.APIKeyWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox apiKeyBox;
        private MaterialSkin.Controls.MaterialButton submitButton;
    }
}