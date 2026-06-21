using System;
using System.Data;
using Bank_BussinusLayer;
using System.Windows.Forms;
using System.ComponentModel;

namespace Bank_System
{
    public partial class frmManageUsers : Form
    {

        enum enPermissions
        {
            eAll = -1, pManageClients = 1, pManageUser = 2, pCurrencyExchange = 4,
            pClientsTransactions = 8
        };

        public frmManageUsers()
        {
            InitializeComponent();
        }

        DataTable _tableUsers = ClsUser.GetAllUsers();
        DataTable _tableLoginRegisters = ClsUser.GetAllLoginUsers();

        // Load Data
        private void _UpdateDateAndTime()
        {

            LbDate.Text = DateTime.Now.ToString("dddd, dd MMM  yyyy");
            LbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {

            _FillingAllUserIDOnComboBox();
            _FillingAllAccountNumberOnComboBox();

            _tableUsers = ClsUser.GetAllUsers();

            DGVUsers.DataSource = _tableUsers;
            LbCountUsers.Text = DGVUsers.Rows.Count.ToString();

            if (DGVUsers.Rows.Count > 0)
            {

                DGVUsers.Columns[0].HeaderText = "User ID";
                DGVUsers.Columns[0].Width = 110;

                DGVUsers.Columns[1].HeaderText = "Person Full Name";
                DGVUsers.Columns[1].Width = 220;

                DGVUsers.Columns[2].HeaderText = "Username";
                DGVUsers.Columns[2].Width = 130;

                DGVUsers.Columns[3].HeaderText = "Gender";
                DGVUsers.Columns[3].Width = 80;

                DGVUsers.Columns[4].HeaderText = "Phone";
                DGVUsers.Columns[4].Width = 130;

                DGVUsers.Columns[5].HeaderText = "Permission";
                DGVUsers.Columns[5].Width = 100;
              
                DGVUsers.Columns[6].HeaderText = "Is Active";
                DGVUsers.Columns[6].Width = 90;

            }


            _tableLoginRegisters = ClsUser.GetAllLoginUsers();

            DGVLoginRegisters.DataSource = _tableLoginRegisters;
            LbCountRegister.Text = DGVLoginRegisters.Rows.Count.ToString();

            if (DGVLoginRegisters.Rows.Count > 0)
            {

                DGVLoginRegisters.Columns[0].HeaderText = "Login ID";
                DGVLoginRegisters.Columns[0].Width = 110;

                DGVLoginRegisters.Columns[1].HeaderText = "User ID";
                DGVLoginRegisters.Columns[1].Width = 110;

                DGVLoginRegisters.Columns[2].HeaderText = "Username";
                DGVLoginRegisters.Columns[2].Width = 150;

                DGVLoginRegisters.Columns[3].HeaderText = "Phone";
                DGVLoginRegisters.Columns[3].Width = 150;

                DGVLoginRegisters.Columns[4].HeaderText = "Permission";
                DGVLoginRegisters.Columns[4].Width = 100;

                DGVLoginRegisters.Columns[5].HeaderText = "Login Date";
                DGVLoginRegisters.Columns[5].Width = 220;

            }

            _DefaultDataForAdd();
            _DefaultDataForUpdate();

        }
        private void frmManageUsers_Shown(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
            LbUserName.Text = $"Welcom {ClsGlobal.CurrentUser.UserName}";
        }

        //Show Users
        private void BtnFindUser_Click(object sender, EventArgs e)
        {

            if (TxtSearchUser.Text.Length > 0)
            {

                _tableUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Username", TxtSearchUser.Text.Trim());
                LbCountUsers.Text = DGVUsers.Rows.Count.ToString();
            }

        }
        private void TxtSearchUser_TextChanged(object sender, EventArgs e)
        {

            if (TxtSearchUser.Text.Trim().Length == 0)
                _tableUsers.DefaultView.RowFilter = "";

            LbCountUsers.Text = DGVUsers.Rows.Count.ToString();

        }

        //Add User
        private void _DefaultDataForAdd()
        {

            CBFindAccountNumber.SelectedIndex = -1;
            AddTxtUsername.Text = "";
            AddTxtPassword.Text = "";

            AddRbYes.Checked = false;
            AddRbNo.Checked = true;

            AddChBManageClients.Checked = false;
            AddChBManageUsers.Checked = false;
            AddChbClientsTransaction.Checked = false;
            AddChBCurrencyExchange.Checked = false;
            
            AddChBIsActive.Checked = true;

            CPBar.Value = 0;
            LbPercent.Text = "0%";

        }
        private void _UpdatePrograssBar()
        {

            Control[] boxes = { AddTxtUsername, AddTxtPassword };

            int filled = 0;

            for (int i = 0; i < boxes.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(boxes[i].Text))
                {
                    filled++;
                }
            }

            int percent = (int)Math.Round((filled * 100.0) / boxes.Length);

            CPBar.Value = percent;
            LbPercent.Text = percent + "%";

        }
        private void _FillingAllAccountNumberOnComboBox()
        {

            CBFindAccountNumber.Items.Clear();
            DataTable table = ClsClient.GetAllClsClients();

            foreach (DataRow row in table.Rows)
            {

                if (!ClsUser.AccountNumberIsUser((int)row["AccountNumber"])) 
                    CBFindAccountNumber.Items.Add(row["AccountNumber"]);
            
            }

        }
        private void TxtEmpty(object sender, CancelEventArgs e)
        {

            Control Temp = ((Control)sender);

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }
        private void TxtLeave(object sender, EventArgs e)
        {

            _UpdatePrograssBar();
        }
        private void _UpdatePermissionsAdd()
        {

            AddChBManageClients.Checked = false;
            AddChBManageUsers.Checked = false;
            AddChbClientsTransaction.Checked = false;
            AddChBCurrencyExchange.Checked = false;

            AddChBManageClients.Enabled = true;
            AddChBManageUsers.Enabled = true;
            AddChbClientsTransaction.Enabled = true;
            AddChBCurrencyExchange.Enabled = true;

            if(AddRbYes.Checked)
            {
                AddChBManageClients.Checked = true;
                AddChBManageUsers.Checked = true;
                AddChbClientsTransaction.Checked = true;
                AddChBCurrencyExchange.Checked = true;

                AddChBManageClients.Enabled = false;
                AddChBManageUsers.Enabled = false;
                AddChbClientsTransaction.Enabled = false;
                AddChBCurrencyExchange.Enabled = false;

            }

        }
        private int _CalculatPermissionsAdd()
        {

            if (AddRbYes.Checked)
                return -1;

            int Permisson = 0;

            if (AddChBManageClients.Checked)
                Permisson += (int)enPermissions.pManageClients;

            if (AddChBManageUsers.Checked)
                Permisson += (int)enPermissions.pManageUser;
            
            if (AddChBCurrencyExchange.Checked)
                Permisson += (int)enPermissions.pCurrencyExchange;

            if (AddChbClientsTransaction.Checked)
                Permisson += (int)enPermissions.pClientsTransactions;

            Permisson = (Permisson == 0 ? 1 : Permisson);

            return Permisson == 15 ? -1 : Permisson;

        }
        private void AddRbYes_CheckedChanged(object sender, EventArgs e)
        {

            _UpdatePermissionsAdd();
        }
        private void AddRbNo_CheckedChanged(object sender, EventArgs e)
        {

            _UpdatePermissionsAdd();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (CBFindAccountNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Select an account number befor", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            string Textrequired = string.Empty;

            if (AddTxtUsername.Text.Trim() == string.Empty)
                Textrequired += "Username";

            if (AddTxtPassword.Text.Trim() == string.Empty)
                Textrequired += ", Password";

            if (Textrequired.StartsWith(","))
                Textrequired = Textrequired.Substring(1, Textrequired.Length - 1).Trim();

            if (Textrequired != string.Empty)
            {
                MessageBox.Show($"There are other required fields \n{Textrequired}", "Not Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if(ClsUser.IsUserExist(AddTxtUsername.Text))
            {

                MessageBox.Show("This username is already used, \n Change it and try again.", "Not Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
                
            }

            ClsUser user = new ClsUser();   
            user.UserName = AddTxtUsername.Text;
            user.Password = AddTxtPassword.Text;
            user.ClientAccountNumber = Convert.ToInt32(CBFindAccountNumber.Text.Trim());
            user.Permissons = _CalculatPermissionsAdd();
            user.IsActive = true;

            if (user.Save())
            {
                MessageBox.Show($"Data Saved Successfully, Your Account Number = {user.UserID}"
                    , "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmManageUsers_Load(null, null);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        //Update User
        private void _DefaultDataForUpdate()
        {

            CBFindUserID.SelectedIndex = -1;
            UpTxtUsername.Text = "";
            UpTxtPassword.Text = "";

            UpRbYes.Checked = false;
            UpRbNo.Checked = true;

            UpChBManageClients.Checked = false;
            UpChBManageUsers.Checked = false;
            UpChBClientsTransactions.Checked = false;
            UpChBCurrencyExchange.Checked = false;

            UpChBIsActive.Checked = false;

        }
        private void _FillingAllUserIDOnComboBox()
        {

            CBFindUserID.Items.Clear();
            DataTable table = ClsUser.GetAllUsers();

            foreach (DataRow row in table.Rows)
            {
                CBFindUserID.Items.Add(row["UserID"]);
            }

        }
        private void _UpdatePermissionsUp()
        {

            UpChBManageClients.Checked = false;
            UpChBManageUsers.Checked = false;
            UpChBClientsTransactions.Checked = false;
            UpChBCurrencyExchange.Checked = false;

            UpChBManageClients.Enabled = true;
            UpChBManageUsers.Enabled = true;
            UpChBClientsTransactions.Enabled = true;
            UpChBCurrencyExchange.Enabled = true;

            if (UpRbYes.Checked)
            {
                UpChBManageClients.Checked = true;
                UpChBManageUsers.Checked = true;
                UpChBClientsTransactions.Checked = true;
                UpChBCurrencyExchange.Checked = true;

                UpChBManageClients.Enabled = false;
                UpChBManageUsers.Enabled = false;
                UpChBClientsTransactions.Enabled = false;
                UpChBCurrencyExchange.Enabled = false;

            }

        }
        private void _ProcessPermission(int Permisson)
        {

            if (Permisson == -1)
            {
                UpChBManageClients.Checked = true;
                UpChBManageUsers.Checked = true;
                UpChBClientsTransactions.Checked = true;
                UpChBCurrencyExchange.Checked = true;

                UpChBManageClients.Enabled = false;
                UpChBManageUsers.Enabled = false;
                UpChBClientsTransactions.Enabled = false;
                UpChBCurrencyExchange.Enabled = false;

                UpRbYes.Checked = true;

                return;
            }

            if ((Permisson - enPermissions.pClientsTransactions) >= 0)
            {
                UpChBClientsTransactions.Checked = true;
                Permisson -= (int)enPermissions.pClientsTransactions;
            }

            if ((Permisson - enPermissions.pCurrencyExchange) >= 0)
            {
                UpChBCurrencyExchange.Checked = true;
                Permisson -= (int)enPermissions.pCurrencyExchange;
            }

            if ((Permisson - enPermissions.pManageUser) >= 0)
            {
                UpChBManageUsers.Checked = true;
                Permisson -= (int)enPermissions.pManageUser;
            }

            if ((Permisson - enPermissions.pManageClients) >= 0)
            {
                UpChBManageClients.Checked = true;
                Permisson -= (int)enPermissions.pManageClients;
            }

        }
        private int _CalculatPermissionsUp()
        {

            if (UpRbYes.Checked)
                return -1;

            int Permisson = 0;

            if (UpChBManageClients.Checked)
                Permisson += (int)enPermissions.pManageClients;

            if (UpChBManageUsers.Checked)
                Permisson += (int)enPermissions.pManageUser;

            if (UpChBCurrencyExchange.Checked)
                Permisson += (int)enPermissions.pCurrencyExchange;

            if (UpChBClientsTransactions.Checked)
                Permisson += (int)enPermissions.pClientsTransactions;

            Permisson = (Permisson == 0 ? 1 : Permisson);

            return Permisson == 15 ? -1 : Permisson;

        }
        private void CBFindUserID_SelectedIndexChanged(object sender, EventArgs e)
        {

            int UserID = Convert.ToInt32(CBFindUserID.Text);

            ClsUser user = ClsUser.FindByUserID(UserID);
            
            UpTxtUsername.Text = user.UserName;
            UpTxtPassword.Text = user.Password;

            _ProcessPermission(user.Permissons);
            UpChBIsActive.Checked = user.IsActive;

        }
        private void UpRbNo_CheckedChanged(object sender, EventArgs e)
        {

            _UpdatePermissionsUp();
        }
        private void UpRbYes_CheckedChanged(object sender, EventArgs e)
        {

            _UpdatePermissionsUp();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if(CBFindUserID.SelectedIndex == -1)
            {
                MessageBox.Show("Select a user id befor", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            string Textrequired = string.Empty;

            if (UpTxtUsername.Text.Trim() == string.Empty)
                Textrequired += "Username";

            if (UpTxtPassword.Text.Trim() == string.Empty)
                Textrequired += ", Password";

            if (Textrequired.StartsWith(","))
                Textrequired = Textrequired.Substring(1, Textrequired.Length - 1).Trim();

            if (Textrequired != string.Empty)
            {
                MessageBox.Show($"There are other required fields \n{Textrequired}", "Not Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            int UserID = Convert.ToInt32(CBFindUserID.Text);
            ClsUser user = ClsUser.FindByUserID(UserID);
            
            if (ClsUser.IsUserExist(UpTxtUsername.Text) && UpTxtUsername.Text != user.UserName)
            {

                MessageBox.Show("This username is already used, \n Change it and try again.", "Not Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            user.UserName = UpTxtUsername.Text;
            user.Password = UpTxtPassword.Text;
            user.IsActive = UpChBIsActive.Checked;

            user.Permissons = _CalculatPermissionsUp();

            if (user.Save())
            {

                MessageBox.Show($"Data Saved Successfully"
                    , "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmManageUsers_Load(null, null);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Login Register
        private void TxtSearchLogin_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearchLogin.Text.Trim().Length == 0)
                _tableLoginRegisters.DefaultView.RowFilter = "";

            LbCountRegister.Text = DGVLoginRegisters.Rows.Count.ToString();

        }
        private void BtnFindLogin_Click(object sender, EventArgs e)
        {

            if (TxtSearchLogin.Text.Length > 0)
            {

                _tableLoginRegisters.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'",
                    "Username", TxtSearchLogin.Text.Trim());

                LbCountRegister.Text = DGVLoginRegisters.Rows.Count.ToString();
            }

        }
    
    }
}
