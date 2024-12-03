namespace PassShield
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.create = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.load = new Siticone.Desktop.UI.WinForms.SiticoneButton();
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
            settings1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            settings1.FontMic = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F);
            settings1.PasswordLength = 16;
            settings1.SettingsKey = "";
            settings1.SubButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(76)))));
            settings1.TextColor = System.Drawing.Color.White;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = settings1.Font;
            this.label1.ForeColor = settings1.TextColor;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добре дошли!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = settings1.Font;
            this.label2.ForeColor = settings1.TextColor;
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Моля изберете запис или създайте нов";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // create
            // 
            this.create.Animated = true;
            this.create.BorderRadius = 10;
            this.create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.create.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F);
            this.create.ForeColor = System.Drawing.Color.White;
            this.create.Location = new System.Drawing.Point(175, 119);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(128, 58);
            this.create.TabIndex = 0;
            this.create.Text = "Създайте запис";
            this.create.Click += new System.EventHandler(this.create_Click_1);
            // 
            // load
            // 
            this.load.Animated = true;
            this.load.BorderRadius = 10;
            this.load.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.load.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.load.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.load.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.load.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.load.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F);
            this.load.ForeColor = System.Drawing.Color.White;
            this.load.Location = new System.Drawing.Point(22, 119);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(128, 58);
            this.load.TabIndex = 4;
            this.load.Text = "Изберете запис";
            this.load.Click += new System.EventHandler(this.load_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = settings1.BackColor;
            this.ClientSize = new System.Drawing.Size(326, 216);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.load);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings1, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(342, 255);
            this.MinimumSize = new System.Drawing.Size(342, 255);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassShield";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton create;
        private Siticone.Desktop.UI.WinForms.SiticoneButton load;
    }
}

