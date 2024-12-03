namespace PassShield
{
    partial class ChangePasswordForm
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
            PassShield.Properties.Settings settings1 = new PassShield.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CNewPassBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.okButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NewPassBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OldPassBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ShowPass = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            settings1.BackColor2 = System.Drawing.Color.Black;
            settings1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings1.PasswordCharacter = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-=+;[]{}" +
    ":.,<>/?";
            settings1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F);
            settings1.FontMic = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F);
            settings1.PasswordLength = 16;
            settings1.SettingsKey = "";
            settings1.SubButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            settings1.TextColor = System.Drawing.Color.White;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = settings1.FontMic;
            this.label1.ForeColor = settings1.TextColor;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Старата ви парола:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = settings1.FontMic;
            this.label2.ForeColor = settings1.TextColor;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Новата ви парола:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = settings1.FontMic;
            this.label3.ForeColor = settings1.TextColor;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Потвърдете новата парола:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CNewPassBox
            // 
            this.CNewPassBox.BorderRadius = 10;
            this.CNewPassBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CNewPassBox.DefaultText = "";
            this.CNewPassBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CNewPassBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CNewPassBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CNewPassBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CNewPassBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CNewPassBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNewPassBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CNewPassBox.Location = new System.Drawing.Point(12, 220);
            this.CNewPassBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CNewPassBox.Name = "CNewPassBox";
            this.CNewPassBox.PasswordChar = '●';
            this.CNewPassBox.PlaceholderText = "Напишете отново новата ви парола тук...";
            this.CNewPassBox.SelectedText = "";
            this.CNewPassBox.Size = new System.Drawing.Size(360, 27);
            this.CNewPassBox.TabIndex = 10;
            this.CNewPassBox.TextChanged += new System.EventHandler(this.CNewPassBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Animated = true;
            this.okButton.BorderRadius = 10;
            this.okButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.okButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(16, 271);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(84, 39);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Запази";
            this.okButton.Click += new System.EventHandler(this.okButton_Click_1);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Силна парола ще пази вашите данни в безопасност";
            // 
            // NewPassBox
            // 
            this.NewPassBox.BorderRadius = 10;
            this.NewPassBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPassBox.DefaultText = "";
            this.NewPassBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPassBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPassBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPassBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPassBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPassBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPassBox.Location = new System.Drawing.Point(12, 158);
            this.NewPassBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.PasswordChar = '●';
            this.NewPassBox.PlaceholderText = "Напишете новата ви парола тук...";
            this.NewPassBox.SelectedText = "";
            this.NewPassBox.Size = new System.Drawing.Size(360, 27);
            this.NewPassBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Сменете вашата парола";
            // 
            // OldPassBox
            // 
            this.OldPassBox.BorderRadius = 10;
            this.OldPassBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OldPassBox.DefaultText = "";
            this.OldPassBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OldPassBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OldPassBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OldPassBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OldPassBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OldPassBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPassBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OldPassBox.Location = new System.Drawing.Point(12, 105);
            this.OldPassBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OldPassBox.Name = "OldPassBox";
            this.OldPassBox.PasswordChar = '●';
            this.OldPassBox.PlaceholderText = "Напишете старата ви парола тук...";
            this.OldPassBox.SelectedText = "";
            this.OldPassBox.Size = new System.Drawing.Size(360, 27);
            this.OldPassBox.TabIndex = 18;
            // 
            // ShowPass
            // 
            this.ShowPass.BorderRadius = 10;
            this.ShowPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShowPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShowPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.ShowPass.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPass.ForeColor = System.Drawing.Color.White;
            this.ShowPass.Location = new System.Drawing.Point(111, 271);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(146, 39);
            this.ShowPass.TabIndex = 19;
            this.ShowPass.Text = "Покажи парола";
            this.ShowPass.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // SchimbareParolaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = settings1.BackColor;
            this.ClientSize = new System.Drawing.Size(384, 331);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.OldPassBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.CNewPassBox);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings1, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchimbareParolaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Промяна на главна парола";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CNewPassBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton okButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox NewPassBox;
        private System.Windows.Forms.Label label7;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox OldPassBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ShowPass;
    }
}