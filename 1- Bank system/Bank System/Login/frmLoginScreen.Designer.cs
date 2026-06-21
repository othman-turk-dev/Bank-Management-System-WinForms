namespace Bank_System
{
    partial class frmLoginScreen
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbTime = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnShowPassword = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.LLQuestion = new System.Windows.Forms.LinkLabel();
            this.CHBRememberMe = new System.Windows.Forms.CheckBox();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LbMessaeError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LbTime);
            this.groupBox1.Controls.Add(this.LbDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(-22, -17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 721);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(148, 634);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version1.0";
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTime.ForeColor = System.Drawing.Color.Snow;
            this.LbTime.Location = new System.Drawing.Point(56, 397);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(56, 20);
            this.LbTime.TabIndex = 3;
            this.LbTime.Text = "Time";
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDate.ForeColor = System.Drawing.Color.Snow;
            this.LbDate.Location = new System.Drawing.Point(56, 364);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(53, 20);
            this.LbDate.TabIndex = 2;
            this.LbDate.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(56, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "_____________________________";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bank_System.Properties.Resources.WhatsApp_Image_2025_08_21_at_03_37_36_15c5ae78;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(59, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 270);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(569, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcom to Our Bank";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnShowPassword);
            this.groupBox2.Controls.Add(this.BtnLogin);
            this.groupBox2.Controls.Add(this.LLQuestion);
            this.groupBox2.Controls.Add(this.CHBRememberMe);
            this.groupBox2.Controls.Add(this.TxtPassword);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtUserName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(523, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 439);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login to Your Account";
            // 
            // BtnShowPassword
            // 
            this.BtnShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.BtnShowPassword.BackgroundImage = global::Bank_System.Properties.Resources.hidden;
            this.BtnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnShowPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnShowPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnShowPassword.FillColor = System.Drawing.Color.Transparent;
            this.BtnShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnShowPassword.ForeColor = System.Drawing.Color.White;
            this.BtnShowPassword.Location = new System.Drawing.Point(317, 193);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.Size = new System.Drawing.Size(59, 36);
            this.BtnShowPassword.TabIndex = 6;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(159, 364);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(180, 45);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LLQuestion
            // 
            this.LLQuestion.ActiveLinkColor = System.Drawing.SystemColors.AppWorkspace;
            this.LLQuestion.AutoSize = true;
            this.LLQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LLQuestion.LinkColor = System.Drawing.Color.SteelBlue;
            this.LLQuestion.Location = new System.Drawing.Point(264, 297);
            this.LLQuestion.Name = "LLQuestion";
            this.LLQuestion.Size = new System.Drawing.Size(216, 22);
            this.LLQuestion.TabIndex = 3;
            this.LLQuestion.TabStop = true;
            this.LLQuestion.Text = "Forgot your password?";
            this.LLQuestion.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.LLQuestion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLQuestion_LinkClicked);
            // 
            // CHBRememberMe
            // 
            this.CHBRememberMe.AutoSize = true;
            this.CHBRememberMe.Checked = true;
            this.CHBRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHBRememberMe.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHBRememberMe.Location = new System.Drawing.Point(41, 295);
            this.CHBRememberMe.Name = "CHBRememberMe";
            this.CHBRememberMe.Size = new System.Drawing.Size(145, 24);
            this.CHBRememberMe.TabIndex = 2;
            this.CHBRememberMe.Text = "Remmber Me";
            this.CHBRememberMe.UseVisualStyleBackColor = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderThickness = 0;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.FillColor = System.Drawing.SystemColors.Control;
            this.TxtPassword.FocusedState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtPassword.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.Location = new System.Drawing.Point(51, 193);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPassword.MaxLength = 10;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PlaceholderText = "";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.Size = new System.Drawing.Size(325, 38);
            this.TxtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(47, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.BorderThickness = 0;
            this.TxtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.DefaultText = "";
            this.TxtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.FillColor = System.Drawing.SystemColors.Control;
            this.TxtUserName.FocusedState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtUserName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserName.Location = new System.Drawing.Point(51, 90);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUserName.MaxLength = 50;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PlaceholderText = "";
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.Size = new System.Drawing.Size(325, 38);
            this.TxtUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(47, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LbMessaeError
            // 
            this.LbMessaeError.AutoSize = true;
            this.LbMessaeError.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMessaeError.ForeColor = System.Drawing.Color.SteelBlue;
            this.LbMessaeError.Location = new System.Drawing.Point(571, 596);
            this.LbMessaeError.Name = "LbMessaeError";
            this.LbMessaeError.Size = new System.Drawing.Size(124, 20);
            this.LbMessaeError.TabIndex = 7;
            this.LbMessaeError.Text = "MessageError";
            this.LbMessaeError.Visible = false;
            // 
            // frmLoginScreen
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1078, 680);
            this.Controls.Add(this.LbMessaeError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserName;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CHBRememberMe;
        private System.Windows.Forms.LinkLabel LLQuestion;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2Button BtnShowPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LbMessaeError;
    }
}

