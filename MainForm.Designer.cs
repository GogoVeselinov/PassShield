namespace PassShield
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199))))), System.Drawing.Color.Empty, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.delButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.replaceButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.hidePassword = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.changePassword = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveChanges = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ShowPass = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.genButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.noteBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siteBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.passBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.loginBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.complexBar = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.lengthPasswordTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.charactersPasswordTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.complexLabel = new System.Windows.Forms.Label();
            this.HelpButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            settings1.BackColor2 = System.Drawing.Color.Black;
            settings1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            settings1.PasswordCharacter = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-=+;[]{}" +
    ":.,<>/?";
            settings1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            settings1.FontMic = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            settings1.PasswordLength = 16;
            settings1.SettingsKey = "";
            settings1.SubButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            settings1.TextColor = System.Drawing.Color.White;
            this.panel1.BackColor = settings1.SubButtonColor;
            this.panel1.Controls.Add(this.HelpButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.delButton);
            this.panel1.Controls.Add(this.replaceButton);
            this.panel1.Controls.Add(this.hidePassword);
            this.panel1.Controls.Add(this.changePassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings1, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 531);
            this.panel1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Animated = true;
            this.addButton.BorderRadius = 10;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.addButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(12, 43);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(159, 60);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Добавяне на акаунт";
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // delButton
            // 
            this.delButton.Animated = true;
            this.delButton.BorderRadius = 10;
            this.delButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.delButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F);
            this.delButton.ForeColor = System.Drawing.Color.White;
            this.delButton.Location = new System.Drawing.Point(12, 109);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(159, 62);
            this.delButton.TabIndex = 20;
            this.delButton.Text = "Изтриване на акаунт";
            this.delButton.Click += new System.EventHandler(this.delButton_Click_1);
            // 
            // replaceButton
            // 
            this.replaceButton.Animated = true;
            this.replaceButton.BorderRadius = 10;
            this.replaceButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.replaceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.replaceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.replaceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.replaceButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.replaceButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F);
            this.replaceButton.ForeColor = System.Drawing.Color.White;
            this.replaceButton.Location = new System.Drawing.Point(12, 177);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(159, 45);
            this.replaceButton.TabIndex = 20;
            this.replaceButton.Text = "Редактиране";
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click_1);
            // 
            // HidePassword
            // 
            // Set up the hidePassword button with custom styles and properties
            this.hidePassword.Animated = true;  // Enable animations for smoother transitions
            this.hidePassword.BorderRadius = 10;  // Round the corners of the button
            this.hidePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;  // Color for disabled button border
            this.hidePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;  // Custom color for disabled state border
            this.hidePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));  // Background color when disabled
            this.hidePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));  // Text color when disabled
            this.hidePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));  // Normal background color
            this.hidePassword.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F);  // Set the font style and size
            this.hidePassword.ForeColor = System.Drawing.Color.White;  // Text color for the button
            this.hidePassword.Location = new System.Drawing.Point(12, 251);  // Position on the form
            this.hidePassword.Name = "hidePassword";  // Set the name of the button (useful for event handling)
            this.hidePassword.Size = new System.Drawing.Size(159, 45);  // Button size
            this.hidePassword.TabIndex = 20;  // Tab order for keyboard navigation
            this.hidePassword.Text = "Покажи парола";  // Button text (in Cyrillic, it means "Show password")
            // 
            // ChangePassword
            // 
            this.changePassword.Animated = true;
            this.changePassword.BorderRadius = 10;
            this.changePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.changePassword.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F);
            this.changePassword.ForeColor = System.Drawing.Color.White;
            this.changePassword.Location = new System.Drawing.Point(11, 302);
            this.changePassword.Name = "schimbareParola";
            this.changePassword.Size = new System.Drawing.Size(159, 58);
            this.changePassword.TabIndex = 20;
            this.changePassword.Text = "Смени главната парола";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.Font = settings1.Font;
            this.label6.Location = new System.Drawing.Point(63, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Опции";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Font = settings1.Font;
            this.label5.Location = new System.Drawing.Point(7, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Редактиране на данни";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.BackColor = settings1.SubButtonColor;
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings1, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = settings1.Font;
            this.button3.ForeColor = settings1.TextColor;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 37);
            this.button3.TabIndex = 11;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Animated = true;
            this.button2.BorderRadius = 10;
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.button2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(625, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 54);
            this.button2.TabIndex = 20;
            this.button2.Text = "Провери сложността";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = settings1.BackColor;
            this.listView1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listView1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings1, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listView1.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listView1.Font = settings1.FontMic;
            this.listView1.ForeColor = settings1.TextColor;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(188, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(808, 318);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveChanges);
            this.groupBox1.Controls.Add(this.ShowPass);
            this.groupBox1.Controls.Add(this.genButton);
            this.groupBox1.Controls.Add(this.noteBox);
            this.groupBox1.Controls.Add(this.siteBox);
            this.groupBox1.Controls.Add(this.passBox);
            this.groupBox1.Controls.Add(this.loginBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.Font = settings1.FontMic;
            this.groupBox1.ForeColor = settings1.TextColor;
            this.groupBox1.Location = new System.Drawing.Point(188, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактиране на данни";
            // 
            // saveChanges
            // 
            this.SaveChanges.Animated = true;
            this.SaveChanges.BorderRadius = 10;
            this.SaveChanges.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveChanges.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveChanges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveChanges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveChanges.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.SaveChanges.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F);
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.Location = new System.Drawing.Point(666, 19);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(136, 70);
            this.SaveChanges.TabIndex = 13;
            this.SaveChanges.Text = "Запазване на данни";
            this.SaveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.Animated = true;
            this.ShowPass.BorderRadius = 10;
            this.ShowPass.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.ToogleButton;
            this.ShowPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShowPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShowPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.ShowPass.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F);
            this.ShowPass.ForeColor = System.Drawing.Color.White;
            this.ShowPass.Location = new System.Drawing.Point(519, 21);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(141, 24);
            this.ShowPass.TabIndex = 12;
            this.ShowPass.Text = "Покажи парола";
            this.ShowPass.Click += new System.EventHandler(this.ShowPass_Click_1);
            // 
            // genButton
            // 
            this.genButton.Animated = true;
            this.genButton.BorderRadius = 10;
            this.genButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.genButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.genButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.genButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.genButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.genButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F);
            this.genButton.ForeColor = System.Drawing.Color.White;
            this.genButton.Location = new System.Drawing.Point(519, 61);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(141, 24);
            this.genButton.TabIndex = 11;
            this.genButton.Text = "Генериране ";
            this.genButton.Click += new System.EventHandler(this.genButton_Click_1);
            // 
            // noteBox
            // 
            this.noteBox.BorderRadius = 10;
            this.noteBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noteBox.DefaultText = "";
            this.noteBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.noteBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.noteBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noteBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noteBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noteBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noteBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noteBox.Location = new System.Drawing.Point(308, 61);
            this.noteBox.Name = "noteBox";
            this.noteBox.PasswordChar = '\0';
            this.noteBox.PlaceholderText = "";
            this.noteBox.SelectedText = "";
            this.noteBox.Size = new System.Drawing.Size(194, 24);
            this.noteBox.TabIndex = 10;
            // 
            // siteBox
            // 
            this.siteBox.BorderRadius = 10;
            this.siteBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siteBox.DefaultText = "";
            this.siteBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siteBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siteBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siteBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siteBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siteBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siteBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siteBox.Location = new System.Drawing.Point(66, 61);
            this.siteBox.Name = "siteBox";
            this.siteBox.PasswordChar = '\0';
            this.siteBox.PlaceholderText = "";
            this.siteBox.SelectedText = "";
            this.siteBox.Size = new System.Drawing.Size(163, 24);
            this.siteBox.TabIndex = 9;
            // 
            // passBox
            // 
            this.passBox.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.passBox.BorderRadius = 10;
            this.passBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passBox.DefaultText = "";
            this.passBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passBox.Location = new System.Drawing.Point(308, 20);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '●';
            this.passBox.PlaceholderText = "";
            this.passBox.SelectedText = "";
            this.passBox.Size = new System.Drawing.Size(194, 24);
            this.passBox.TabIndex = 8;
            // 
            // loginBox
            // 
            this.loginBox.AutoRoundedCorners = true;
            this.loginBox.BorderRadius = 11;
            this.loginBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginBox.DefaultText = "";
            this.loginBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginBox.Location = new System.Drawing.Point(66, 20);
            this.loginBox.Name = "loginBox";
            this.loginBox.PasswordChar = '\0';
            this.loginBox.PlaceholderText = "";
            this.loginBox.SelectedText = "";
            this.loginBox.Size = new System.Drawing.Size(163, 24);
            this.loginBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = settings1.TextColor;
            this.label4.Location = new System.Drawing.Point(232, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Записки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = settings1.TextColor;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сайт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = settings1.TextColor;
            this.label2.Location = new System.Drawing.Point(237, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Парола:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = settings1.TextColor;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Акаунт:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.Font = settings1.FontMic;
            this.label7.ForeColor = settings1.TextColor;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Допустими знаци за парола";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.Font = settings1.FontMic;
            this.label8.ForeColor = settings1.TextColor;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Дължина на парола:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.complexBar);
            this.groupBox2.Controls.Add(this.lengthPasswordTextBox);
            this.groupBox2.Controls.Add(this.charactersPasswordTextBox);
            this.groupBox2.Controls.Add(this.complexLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.Font = settings1.FontMic;
            this.groupBox2.ForeColor = settings1.TextColor;
            this.groupBox2.Location = new System.Drawing.Point(188, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 78);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Опции";
            // 
            // complexBar
            // 
            this.complexBar.BorderRadius = 10;
            this.complexBar.FillColor = System.Drawing.Color.White;
            this.complexBar.Location = new System.Drawing.Point(385, 44);
            this.complexBar.Name = "complexBar";
            this.complexBar.Size = new System.Drawing.Size(234, 21);
            this.complexBar.TabIndex = 24;
            this.complexBar.Text = "siticoneProgressBar1";
            this.complexBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lengthPasswordTextBox
            // 
            this.lengthPasswordTextBox.BorderRadius = 10;
            this.lengthPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lengthPasswordTextBox.DefaultText = "";
            this.lengthPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lengthPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lengthPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lengthPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lengthPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lengthPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lengthPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lengthPasswordTextBox.Location = new System.Drawing.Point(154, 44);
            this.lengthPasswordTextBox.Name = "LengthPasswordTextBox";
            this.lengthPasswordTextBox.PasswordChar = '\0';
            this.lengthPasswordTextBox.PlaceholderText = "";
            this.lengthPasswordTextBox.SelectedText = "";
            this.lengthPasswordTextBox.Size = new System.Drawing.Size(75, 21);
            this.lengthPasswordTextBox.TabIndex = 23;
            // 
            // CharactersPasswordTextBox
            // 
            this.charactersPasswordTextBox.BorderRadius = 10;
            this.charactersPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.charactersPasswordTextBox.DefaultText = "";
            this.charactersPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.charactersPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.charactersPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.charactersPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.charactersPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.charactersPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.charactersPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.charactersPasswordTextBox.Location = new System.Drawing.Point(216, 17);
            this.charactersPasswordTextBox.Name = "charactersPasswordTextBox";
            this.charactersPasswordTextBox.PasswordChar = '\0';
            this.charactersPasswordTextBox.PlaceholderText = "";
            this.charactersPasswordTextBox.SelectedText = "";
            this.charactersPasswordTextBox.Size = new System.Drawing.Size(403, 21);
            this.charactersPasswordTextBox.TabIndex = 21;
            // 
            // complexLabel
            // 
            this.complexLabel.AutoSize = true;
            this.complexLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.complexLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "FontMic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.complexLabel.Font = settings1.FontMic;
            this.complexLabel.ForeColor = settings1.TextColor;
            this.complexLabel.Location = new System.Drawing.Point(231, 44);
            this.complexLabel.Name = "complexLabel";
            this.complexLabel.Size = new System.Drawing.Size(131, 18);
            this.complexLabel.TabIndex = 20;
            this.complexLabel.Text = "Сложност (0/100):";
            // 
            // HelpButton
            // 
            this.HelpButton.Animated = true;
            this.HelpButton.BorderRadius = 10;
            this.HelpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HelpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HelpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HelpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HelpButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.HelpButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F);
            this.HelpButton.ForeColor = System.Drawing.Color.White;
            this.HelpButton.Location = new System.Drawing.Point(11, 366);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(159, 58);
            this.HelpButton.TabIndex = 21;
            this.HelpButton.Text = "Помощ";
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // MainAtomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = settings1.BackColor;
            this.ClientSize = new System.Drawing.Size(1008, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings1, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = settings1.TextColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainAtomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassShield Manager";
            this.Load += new System.EventHandler(this.MainAtomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label complexLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox noteBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siteBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox passBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox loginBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox lengthPasswordTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox charactersPasswordTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar complexBar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ShowPass;
        private Siticone.Desktop.UI.WinForms.SiticoneButton genButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SaveChanges;
        private Siticone.Desktop.UI.WinForms.SiticoneButton button2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton changePassword;
        private Siticone.Desktop.UI.WinForms.SiticoneButton hidePassword;
        private Siticone.Desktop.UI.WinForms.SiticoneButton replaceButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton delButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton HelpButton;
    }
}