namespace Bank_System
{
    partial class frmClientsTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LbTime = new System.Windows.Forms.Label();
            this.LbUserName = new System.Windows.Forms.Label();
            this.TbManageUsers = new System.Windows.Forms.TabControl();
            this.TbDeposit = new System.Windows.Forms.TabPage();
            this.BtnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.DepNumberUpBalance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DepLbBalance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DepCBFindAccountNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbWithdraw = new System.Windows.Forms.TabPage();
            this.BtnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.WithNumberUpBalance = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.WithLbBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WithCBFindAccountNumber = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TbTotalBalance = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbNumberBalance = new System.Windows.Forms.Label();
            this.LbTxtBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalLbCountRecords = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalBtnFind = new Guna.UI2.WinForms.Guna2Button();
            this.DGVTotalBalance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TotalTxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbTransferBalance = new System.Windows.Forms.TabPage();
            this.LbDestinationBalance = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CBDestinationBalance = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.NumericAmountTransfer = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.LbSourseBalance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CBSourseBalance = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TbTransferLog = new System.Windows.Forms.TabPage();
            this.LbCountTransferLog = new System.Windows.Forms.Label();
            this.LL = new System.Windows.Forms.Label();
            this.BtnFindLog = new Guna.UI2.WinForms.Guna2Button();
            this.DGVTransferLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TxtSearchLog = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbManageUsers.SuspendLayout();
            this.TbDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepNumberUpBalance)).BeginInit();
            this.TbWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WithNumberUpBalance)).BeginInit();
            this.TbTotalBalance.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTotalBalance)).BeginInit();
            this.TbTransferBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAmountTransfer)).BeginInit();
            this.TbTransferLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransferLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTime.ForeColor = System.Drawing.Color.Snow;
            this.LbTime.Location = new System.Drawing.Point(55, 436);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(56, 20);
            this.LbTime.TabIndex = 7;
            this.LbTime.Text = "Time";
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserName.ForeColor = System.Drawing.Color.Snow;
            this.LbUserName.Location = new System.Drawing.Point(105, 357);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(127, 25);
            this.LbUserName.TabIndex = 7;
            this.LbUserName.Text = "UserName";
            // 
            // TbManageUsers
            // 
            this.TbManageUsers.Controls.Add(this.TbDeposit);
            this.TbManageUsers.Controls.Add(this.TbWithdraw);
            this.TbManageUsers.Controls.Add(this.TbTotalBalance);
            this.TbManageUsers.Controls.Add(this.TbTransferBalance);
            this.TbManageUsers.Controls.Add(this.TbTransferLog);
            this.TbManageUsers.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbManageUsers.Location = new System.Drawing.Point(492, 3);
            this.TbManageUsers.Name = "TbManageUsers";
            this.TbManageUsers.SelectedIndex = 0;
            this.TbManageUsers.Size = new System.Drawing.Size(1036, 713);
            this.TbManageUsers.TabIndex = 7;
            // 
            // TbDeposit
            // 
            this.TbDeposit.Controls.Add(this.BtnDeposit);
            this.TbDeposit.Controls.Add(this.DepNumberUpBalance);
            this.TbDeposit.Controls.Add(this.label2);
            this.TbDeposit.Controls.Add(this.DepLbBalance);
            this.TbDeposit.Controls.Add(this.label15);
            this.TbDeposit.Controls.Add(this.DepCBFindAccountNumber);
            this.TbDeposit.Controls.Add(this.label5);
            this.TbDeposit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDeposit.Location = new System.Drawing.Point(4, 31);
            this.TbDeposit.Name = "TbDeposit";
            this.TbDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.TbDeposit.Size = new System.Drawing.Size(1015, 678);
            this.TbDeposit.TabIndex = 0;
            this.TbDeposit.Text = "Deposit";
            this.TbDeposit.UseVisualStyleBackColor = true;
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeposit.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnDeposit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeposit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDeposit.Location = new System.Drawing.Point(726, 544);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(222, 63);
            this.BtnDeposit.TabIndex = 58;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // DepNumberUpBalance
            // 
            this.DepNumberUpBalance.BackColor = System.Drawing.Color.Transparent;
            this.DepNumberUpBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepNumberUpBalance.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.DepNumberUpBalance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepNumberUpBalance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.DepNumberUpBalance.Location = new System.Drawing.Point(77, 408);
            this.DepNumberUpBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepNumberUpBalance.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.DepNumberUpBalance.Name = "DepNumberUpBalance";
            this.DepNumberUpBalance.Size = new System.Drawing.Size(205, 40);
            this.DepNumberUpBalance.TabIndex = 57;
            this.DepNumberUpBalance.UpDownButtonFillColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(73, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "Deposit Amount:";
            // 
            // DepLbBalance
            // 
            this.DepLbBalance.AutoSize = true;
            this.DepLbBalance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepLbBalance.ForeColor = System.Drawing.Color.SteelBlue;
            this.DepLbBalance.Location = new System.Drawing.Point(270, 249);
            this.DepLbBalance.Name = "DepLbBalance";
            this.DepLbBalance.Size = new System.Drawing.Size(27, 28);
            this.DepLbBalance.TabIndex = 55;
            this.DepLbBalance.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(72, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 25);
            this.label15.TabIndex = 54;
            this.label15.Text = "Current balance is:";
            // 
            // DepCBFindAccountNumber
            // 
            this.DepCBFindAccountNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepCBFindAccountNumber.FormattingEnabled = true;
            this.DepCBFindAccountNumber.Location = new System.Drawing.Point(77, 117);
            this.DepCBFindAccountNumber.Name = "DepCBFindAccountNumber";
            this.DepCBFindAccountNumber.Size = new System.Drawing.Size(233, 33);
            this.DepCBFindAccountNumber.TabIndex = 51;
            this.DepCBFindAccountNumber.SelectedIndexChanged += new System.EventHandler(this.DepCBFindAccountNumber_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(73, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Account Number";
            // 
            // TbWithdraw
            // 
            this.TbWithdraw.Controls.Add(this.BtnWithdraw);
            this.TbWithdraw.Controls.Add(this.WithNumberUpBalance);
            this.TbWithdraw.Controls.Add(this.label3);
            this.TbWithdraw.Controls.Add(this.WithLbBalance);
            this.TbWithdraw.Controls.Add(this.label8);
            this.TbWithdraw.Controls.Add(this.WithCBFindAccountNumber);
            this.TbWithdraw.Controls.Add(this.label11);
            this.TbWithdraw.Location = new System.Drawing.Point(4, 31);
            this.TbWithdraw.Name = "TbWithdraw";
            this.TbWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.TbWithdraw.Size = new System.Drawing.Size(1015, 678);
            this.TbWithdraw.TabIndex = 1;
            this.TbWithdraw.Text = "Withdraw";
            this.TbWithdraw.UseVisualStyleBackColor = true;
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnWithdraw.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnWithdraw.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWithdraw.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnWithdraw.Location = new System.Drawing.Point(723, 538);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(222, 63);
            this.BtnWithdraw.TabIndex = 65;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // WithNumberUpBalance
            // 
            this.WithNumberUpBalance.BackColor = System.Drawing.Color.Transparent;
            this.WithNumberUpBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WithNumberUpBalance.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.WithNumberUpBalance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithNumberUpBalance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WithNumberUpBalance.Location = new System.Drawing.Point(74, 402);
            this.WithNumberUpBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WithNumberUpBalance.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.WithNumberUpBalance.Name = "WithNumberUpBalance";
            this.WithNumberUpBalance.Size = new System.Drawing.Size(233, 40);
            this.WithNumberUpBalance.TabIndex = 64;
            this.WithNumberUpBalance.UpDownButtonFillColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(70, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Withdraw Amount:";
            // 
            // WithLbBalance
            // 
            this.WithLbBalance.AutoSize = true;
            this.WithLbBalance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithLbBalance.ForeColor = System.Drawing.Color.SteelBlue;
            this.WithLbBalance.Location = new System.Drawing.Point(267, 243);
            this.WithLbBalance.Name = "WithLbBalance";
            this.WithLbBalance.Size = new System.Drawing.Size(27, 28);
            this.WithLbBalance.TabIndex = 62;
            this.WithLbBalance.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(69, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 25);
            this.label8.TabIndex = 61;
            this.label8.Text = "Current balance is:";
            // 
            // WithCBFindAccountNumber
            // 
            this.WithCBFindAccountNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WithCBFindAccountNumber.FormattingEnabled = true;
            this.WithCBFindAccountNumber.Location = new System.Drawing.Point(74, 111);
            this.WithCBFindAccountNumber.Name = "WithCBFindAccountNumber";
            this.WithCBFindAccountNumber.Size = new System.Drawing.Size(233, 30);
            this.WithCBFindAccountNumber.TabIndex = 60;
            this.WithCBFindAccountNumber.SelectedIndexChanged += new System.EventHandler(this.WithCBFindAccountNumber_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(70, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 22);
            this.label11.TabIndex = 59;
            this.label11.Text = "Account Number";
            // 
            // TbTotalBalance
            // 
            this.TbTotalBalance.Controls.Add(this.panel2);
            this.TbTotalBalance.Controls.Add(this.TotalLbCountRecords);
            this.TbTotalBalance.Controls.Add(this.label6);
            this.TbTotalBalance.Controls.Add(this.TotalBtnFind);
            this.TbTotalBalance.Controls.Add(this.DGVTotalBalance);
            this.TbTotalBalance.Controls.Add(this.TotalTxtSearch);
            this.TbTotalBalance.Controls.Add(this.label7);
            this.TbTotalBalance.Location = new System.Drawing.Point(4, 31);
            this.TbTotalBalance.Name = "TbTotalBalance";
            this.TbTotalBalance.Size = new System.Drawing.Size(1015, 678);
            this.TbTotalBalance.TabIndex = 2;
            this.TbTotalBalance.Text = "TotalBalance";
            this.TbTotalBalance.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.LbNumberBalance);
            this.panel2.Controls.Add(this.LbTxtBalance);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 117);
            this.panel2.TabIndex = 16;
            // 
            // LbNumberBalance
            // 
            this.LbNumberBalance.AutoSize = true;
            this.LbNumberBalance.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNumberBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbNumberBalance.Location = new System.Drawing.Point(271, 24);
            this.LbNumberBalance.Name = "LbNumberBalance";
            this.LbNumberBalance.Size = new System.Drawing.Size(67, 36);
            this.LbNumberBalance.TabIndex = 2;
            this.LbNumberBalance.Text = "(0$)";
            // 
            // LbTxtBalance
            // 
            this.LbTxtBalance.AutoSize = true;
            this.LbTxtBalance.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTxtBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbTxtBalance.Location = new System.Drawing.Point(83, 71);
            this.LbTxtBalance.Name = "LbTxtBalance";
            this.LbTxtBalance.Size = new System.Drawing.Size(192, 36);
            this.LbTxtBalance.TabIndex = 1;
            this.LbTxtBalance.Text = "(Zero) Dollars";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(73, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Balance is: ";
            // 
            // TotalLbCountRecords
            // 
            this.TotalLbCountRecords.AutoSize = true;
            this.TotalLbCountRecords.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbCountRecords.ForeColor = System.Drawing.Color.SteelBlue;
            this.TotalLbCountRecords.Location = new System.Drawing.Point(773, 274);
            this.TotalLbCountRecords.Name = "TotalLbCountRecords";
            this.TotalLbCountRecords.Size = new System.Drawing.Size(20, 20);
            this.TotalLbCountRecords.TabIndex = 15;
            this.TotalLbCountRecords.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(655, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total records:";
            // 
            // TotalBtnFind
            // 
            this.TotalBtnFind.BackColor = System.Drawing.Color.Transparent;
            this.TotalBtnFind.BackgroundImage = global::Bank_System.Properties.Resources.research;
            this.TotalBtnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TotalBtnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TotalBtnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TotalBtnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TotalBtnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TotalBtnFind.FillColor = System.Drawing.Color.Transparent;
            this.TotalBtnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TotalBtnFind.ForeColor = System.Drawing.Color.White;
            this.TotalBtnFind.Location = new System.Drawing.Point(244, 217);
            this.TotalBtnFind.Name = "TotalBtnFind";
            this.TotalBtnFind.Size = new System.Drawing.Size(59, 36);
            this.TotalBtnFind.TabIndex = 13;
            this.TotalBtnFind.Click += new System.EventHandler(this.TotalBtnFind_Click);
            // 
            // DGVTotalBalance
            // 
            this.DGVTotalBalance.AllowUserToAddRows = false;
            this.DGVTotalBalance.AllowUserToDeleteRows = false;
            this.DGVTotalBalance.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVTotalBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVTotalBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTotalBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVTotalBalance.ColumnHeadersHeight = 30;
            this.DGVTotalBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTotalBalance.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVTotalBalance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTotalBalance.Location = new System.Drawing.Point(3, 305);
            this.DGVTotalBalance.Name = "DGVTotalBalance";
            this.DGVTotalBalance.ReadOnly = true;
            this.DGVTotalBalance.RowHeadersVisible = false;
            this.DGVTotalBalance.RowHeadersWidth = 51;
            this.DGVTotalBalance.RowTemplate.Height = 26;
            this.DGVTotalBalance.Size = new System.Drawing.Size(805, 334);
            this.DGVTotalBalance.TabIndex = 12;
            this.DGVTotalBalance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTotalBalance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVTotalBalance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVTotalBalance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVTotalBalance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVTotalBalance.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVTotalBalance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTotalBalance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVTotalBalance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVTotalBalance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTotalBalance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVTotalBalance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVTotalBalance.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVTotalBalance.ThemeStyle.ReadOnly = true;
            this.DGVTotalBalance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTotalBalance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTotalBalance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTotalBalance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVTotalBalance.ThemeStyle.RowsStyle.Height = 26;
            this.DGVTotalBalance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTotalBalance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TotalTxtSearch
            // 
            this.TotalTxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalTxtSearch.DefaultText = "";
            this.TotalTxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TotalTxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TotalTxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotalTxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotalTxtSearch.FocusedState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.TotalTxtSearch.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.TotalTxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TotalTxtSearch.Location = new System.Drawing.Point(24, 217);
            this.TotalTxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalTxtSearch.Name = "TotalTxtSearch";
            this.TotalTxtSearch.PlaceholderText = "";
            this.TotalTxtSearch.SelectedText = "";
            this.TotalTxtSearch.Size = new System.Drawing.Size(267, 35);
            this.TotalTxtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TotalTxtSearch.TabIndex = 11;
            this.TotalTxtSearch.TextChanged += new System.EventHandler(this.TotalTxtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(20, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Search Account Number";
            // 
            // TbTransferBalance
            // 
            this.TbTransferBalance.Controls.Add(this.LbDestinationBalance);
            this.TbTransferBalance.Controls.Add(this.label17);
            this.TbTransferBalance.Controls.Add(this.CBDestinationBalance);
            this.TbTransferBalance.Controls.Add(this.label18);
            this.TbTransferBalance.Controls.Add(this.BtnTransfer);
            this.TbTransferBalance.Controls.Add(this.NumericAmountTransfer);
            this.TbTransferBalance.Controls.Add(this.label10);
            this.TbTransferBalance.Controls.Add(this.LbSourseBalance);
            this.TbTransferBalance.Controls.Add(this.label13);
            this.TbTransferBalance.Controls.Add(this.CBSourseBalance);
            this.TbTransferBalance.Controls.Add(this.label14);
            this.TbTransferBalance.Location = new System.Drawing.Point(4, 31);
            this.TbTransferBalance.Name = "TbTransferBalance";
            this.TbTransferBalance.Size = new System.Drawing.Size(1015, 678);
            this.TbTransferBalance.TabIndex = 3;
            this.TbTransferBalance.Text = "Transfer Balance";
            this.TbTransferBalance.UseVisualStyleBackColor = true;
            // 
            // LbDestinationBalance
            // 
            this.LbDestinationBalance.AutoSize = true;
            this.LbDestinationBalance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDestinationBalance.ForeColor = System.Drawing.Color.SteelBlue;
            this.LbDestinationBalance.Location = new System.Drawing.Point(747, 243);
            this.LbDestinationBalance.Name = "LbDestinationBalance";
            this.LbDestinationBalance.Size = new System.Drawing.Size(27, 28);
            this.LbDestinationBalance.TabIndex = 76;
            this.LbDestinationBalance.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(549, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(206, 25);
            this.label17.TabIndex = 75;
            this.label17.Text = "Current balance is:";
            // 
            // CBDestinationBalance
            // 
            this.CBDestinationBalance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDestinationBalance.FormattingEnabled = true;
            this.CBDestinationBalance.Location = new System.Drawing.Point(554, 111);
            this.CBDestinationBalance.Name = "CBDestinationBalance";
            this.CBDestinationBalance.Size = new System.Drawing.Size(233, 30);
            this.CBDestinationBalance.TabIndex = 74;
            this.CBDestinationBalance.SelectedIndexChanged += new System.EventHandler(this.CBDestinationBalance_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SteelBlue;
            this.label18.Location = new System.Drawing.Point(550, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 22);
            this.label18.TabIndex = 73;
            this.label18.Text = "To Acc. Number";
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTransfer.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnTransfer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransfer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnTransfer.Location = new System.Drawing.Point(723, 538);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(222, 63);
            this.BtnTransfer.TabIndex = 72;
            this.BtnTransfer.Text = "Transfer";
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // NumericAmountTransfer
            // 
            this.NumericAmountTransfer.BackColor = System.Drawing.Color.Transparent;
            this.NumericAmountTransfer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericAmountTransfer.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.NumericAmountTransfer.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericAmountTransfer.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericAmountTransfer.Location = new System.Drawing.Point(74, 402);
            this.NumericAmountTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericAmountTransfer.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.NumericAmountTransfer.Name = "NumericAmountTransfer";
            this.NumericAmountTransfer.Size = new System.Drawing.Size(205, 40);
            this.NumericAmountTransfer.TabIndex = 71;
            this.NumericAmountTransfer.UpDownButtonFillColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(70, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 22);
            this.label10.TabIndex = 70;
            this.label10.Text = "Transfer Amount:";
            // 
            // LbSourseBalance
            // 
            this.LbSourseBalance.AutoSize = true;
            this.LbSourseBalance.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSourseBalance.ForeColor = System.Drawing.Color.SteelBlue;
            this.LbSourseBalance.Location = new System.Drawing.Point(267, 243);
            this.LbSourseBalance.Name = "LbSourseBalance";
            this.LbSourseBalance.Size = new System.Drawing.Size(27, 28);
            this.LbSourseBalance.TabIndex = 69;
            this.LbSourseBalance.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(69, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 25);
            this.label13.TabIndex = 68;
            this.label13.Text = "Current balance is:";
            // 
            // CBSourseBalance
            // 
            this.CBSourseBalance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSourseBalance.FormattingEnabled = true;
            this.CBSourseBalance.Location = new System.Drawing.Point(74, 111);
            this.CBSourseBalance.Name = "CBSourseBalance";
            this.CBSourseBalance.Size = new System.Drawing.Size(233, 30);
            this.CBSourseBalance.TabIndex = 67;
            this.CBSourseBalance.SelectedIndexChanged += new System.EventHandler(this.CBSourseBalance_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(70, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 22);
            this.label14.TabIndex = 66;
            this.label14.Text = "From Acc. Number";
            // 
            // TbTransferLog
            // 
            this.TbTransferLog.Controls.Add(this.LbCountTransferLog);
            this.TbTransferLog.Controls.Add(this.LL);
            this.TbTransferLog.Controls.Add(this.BtnFindLog);
            this.TbTransferLog.Controls.Add(this.DGVTransferLog);
            this.TbTransferLog.Controls.Add(this.TxtSearchLog);
            this.TbTransferLog.Controls.Add(this.label16);
            this.TbTransferLog.Location = new System.Drawing.Point(4, 31);
            this.TbTransferLog.Name = "TbTransferLog";
            this.TbTransferLog.Size = new System.Drawing.Size(1028, 678);
            this.TbTransferLog.TabIndex = 4;
            this.TbTransferLog.Text = "Transfer Log";
            this.TbTransferLog.UseVisualStyleBackColor = true;
            // 
            // LbCountTransferLog
            // 
            this.LbCountTransferLog.AutoSize = true;
            this.LbCountTransferLog.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCountTransferLog.ForeColor = System.Drawing.Color.SteelBlue;
            this.LbCountTransferLog.Location = new System.Drawing.Point(978, 153);
            this.LbCountTransferLog.Name = "LbCountTransferLog";
            this.LbCountTransferLog.Size = new System.Drawing.Size(20, 20);
            this.LbCountTransferLog.TabIndex = 22;
            this.LbCountTransferLog.Text = "0";
            // 
            // LL
            // 
            this.LL.AutoSize = true;
            this.LL.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL.ForeColor = System.Drawing.Color.DimGray;
            this.LL.Location = new System.Drawing.Point(862, 153);
            this.LL.Name = "LL";
            this.LL.Size = new System.Drawing.Size(126, 20);
            this.LL.TabIndex = 21;
            this.LL.Text = "Total records:";
            // 
            // BtnFindLog
            // 
            this.BtnFindLog.BackColor = System.Drawing.Color.Transparent;
            this.BtnFindLog.BackgroundImage = global::Bank_System.Properties.Resources.research;
            this.BtnFindLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFindLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFindLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFindLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFindLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFindLog.FillColor = System.Drawing.Color.Transparent;
            this.BtnFindLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnFindLog.ForeColor = System.Drawing.Color.White;
            this.BtnFindLog.Location = new System.Drawing.Point(242, 96);
            this.BtnFindLog.Name = "BtnFindLog";
            this.BtnFindLog.Size = new System.Drawing.Size(59, 36);
            this.BtnFindLog.TabIndex = 20;
            // 
            // DGVTransferLog
            // 
            this.DGVTransferLog.AllowUserToAddRows = false;
            this.DGVTransferLog.AllowUserToDeleteRows = false;
            this.DGVTransferLog.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVTransferLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVTransferLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTransferLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVTransferLog.ColumnHeadersHeight = 30;
            this.DGVTransferLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTransferLog.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVTransferLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTransferLog.Location = new System.Drawing.Point(0, 187);
            this.DGVTransferLog.Name = "DGVTransferLog";
            this.DGVTransferLog.ReadOnly = true;
            this.DGVTransferLog.RowHeadersVisible = false;
            this.DGVTransferLog.RowHeadersWidth = 51;
            this.DGVTransferLog.RowTemplate.Height = 26;
            this.DGVTransferLog.Size = new System.Drawing.Size(1024, 473);
            this.DGVTransferLog.TabIndex = 19;
            this.DGVTransferLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTransferLog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVTransferLog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVTransferLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVTransferLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVTransferLog.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVTransferLog.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTransferLog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVTransferLog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVTransferLog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTransferLog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVTransferLog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVTransferLog.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVTransferLog.ThemeStyle.ReadOnly = true;
            this.DGVTransferLog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTransferLog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTransferLog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTransferLog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVTransferLog.ThemeStyle.RowsStyle.Height = 26;
            this.DGVTransferLog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTransferLog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TxtSearchLog
            // 
            this.TxtSearchLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearchLog.DefaultText = "";
            this.TxtSearchLog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearchLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearchLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchLog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchLog.FocusedState.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtSearchLog.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchLog.ForeColor = System.Drawing.Color.DimGray;
            this.TxtSearchLog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchLog.Location = new System.Drawing.Point(22, 97);
            this.TxtSearchLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearchLog.Name = "TxtSearchLog";
            this.TxtSearchLog.PlaceholderText = "";
            this.TxtSearchLog.SelectedText = "";
            this.TxtSearchLog.Size = new System.Drawing.Size(267, 35);
            this.TxtSearchLog.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtSearchLog.TabIndex = 18;
            this.TxtSearchLog.TextChanged += new System.EventHandler(this.TxtSearchLog_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
            this.label16.Location = new System.Drawing.Point(18, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Search UserName";
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDate.ForeColor = System.Drawing.Color.Snow;
            this.LbDate.Location = new System.Drawing.Point(55, 403);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(53, 20);
            this.LbDate.TabIndex = 6;
            this.LbDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(144, 677);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.LbTime);
            this.groupBox1.Controls.Add(this.LbDate);
            this.groupBox1.Controls.Add(this.LbUserName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, -29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 764);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(55, 368);
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
            // frmClientsTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 706);
            this.Controls.Add(this.TbManageUsers);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmClientsTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clients Transactions";
            this.Load += new System.EventHandler(this.frmClientsTransactions_Load);
            this.Shown += new System.EventHandler(this.frmClientsTransactions_Shown);
            this.TbManageUsers.ResumeLayout(false);
            this.TbDeposit.ResumeLayout(false);
            this.TbDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepNumberUpBalance)).EndInit();
            this.TbWithdraw.ResumeLayout(false);
            this.TbWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WithNumberUpBalance)).EndInit();
            this.TbTotalBalance.ResumeLayout(false);
            this.TbTotalBalance.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTotalBalance)).EndInit();
            this.TbTransferBalance.ResumeLayout(false);
            this.TbTransferBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAmountTransfer)).EndInit();
            this.TbTransferLog.ResumeLayout(false);
            this.TbTransferLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransferLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.TabControl TbManageUsers;
        private System.Windows.Forms.TabPage TbDeposit;
        private System.Windows.Forms.TabPage TbWithdraw;
        private System.Windows.Forms.TabPage TbTotalBalance;
        private System.Windows.Forms.TabPage TbTransferBalance;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox DepCBFindAccountNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage TbTransferLog;
        private System.Windows.Forms.Label DepLbBalance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown DepNumberUpBalance;
        private Guna.UI2.WinForms.Guna2Button BtnDeposit;
        private Guna.UI2.WinForms.Guna2Button BtnWithdraw;
        private Guna.UI2.WinForms.Guna2NumericUpDown WithNumberUpBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WithLbBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox WithCBFindAccountNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button TotalBtnFind;
        private Guna.UI2.WinForms.Guna2DataGridView DGVTotalBalance;
        private Guna.UI2.WinForms.Guna2TextBox TotalTxtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalLbCountRecords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbNumberBalance;
        private System.Windows.Forms.Label LbTxtBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LbDestinationBalance;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CBDestinationBalance;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2Button BtnTransfer;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericAmountTransfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LbSourseBalance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CBSourseBalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LbCountTransferLog;
        private System.Windows.Forms.Label LL;
        private Guna.UI2.WinForms.Guna2Button BtnFindLog;
        private Guna.UI2.WinForms.Guna2DataGridView DGVTransferLog;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearchLog;
        private System.Windows.Forms.Label label16;
    }
}