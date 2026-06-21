using System;
using System.Data;
using Bank_BussinusLayer;
using System.Windows.Forms;
using System.ComponentModel;

namespace Bank_System
{
    public partial class frmManageClients : Form
    {
        public frmManageClients()
        {
            InitializeComponent();
        }

        DataTable _table = ClsClient.GetAllClsClients();
        
        //Load Data
        private void timer1_Tick(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
        }
        private void _UpdateDateAndTime()
        {

            LbDate.Text = DateTime.Now.ToString("dddd, dd MMM  yyyy");
            LbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void frmManageClients_Load(object sender, EventArgs e)
        {

            _FillingAllAccountNumberOnComboBox();

            _table = ClsClient.GetAllClsClients();
            DGVClients.DataSource = _table;
            LbCountRecords.Text = DGVClients.Rows.Count.ToString();

            if (DGVClients.Rows.Count > 0)
            {

                DGVClients.Columns[0].HeaderText = "Acc.Number";
                DGVClients.Columns[0].Width = 110;

                DGVClients.Columns[1].HeaderText = "Person Full Name";
                DGVClients.Columns[1].Width = 270;

                DGVClients.Columns[2].HeaderText = "Gender";
                DGVClients.Columns[2].Width = 80;

                DGVClients.Columns[3].HeaderText = "Phone";
                DGVClients.Columns[3].Width = 130;

                DGVClients.Columns[4].HeaderText = "Country Name";
                DGVClients.Columns[4].Width = 130;

                DGVClients.Columns[5].HeaderText = "Balance";
                DGVClients.Columns[5].Width = 100;

            }

            _DefaultDataForAdd();
            _DefaultDataForUpdate();

        }
        private void frmManageClients_Shown(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
            _FillingAllCountriesOnComboBox();
            LbUserName.Text = $"Welcom {ClsGlobal.CurrentUser.UserName}";
        }
        private void frmManageClients_Activated(object sender, EventArgs e)
        {

            TxtSearch.Focus();
        }

        //Show Clients 
        private void BtnFind_Click(object sender, EventArgs e)
        {

            if (TxtSearch.Text.Length > 0)
            {

                _table.DefaultView.RowFilter = string.Format("[{0}] = {1}", "AccountNumber", TxtSearch.Text.Trim());
                LbCountRecords.Text = DGVClients.Rows.Count.ToString();
            }

        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

            if (TxtSearch.Text.Trim().Length == 0)
                _table.DefaultView.RowFilter = "";

            LbCountRecords.Text = DGVClients.Rows.Count.ToString();
        }
        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Client [" + DGVClients.CurrentRow.Cells[0].Value + "]"
                , "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                ClsClient client = ClsClient.FindByAccountNumber((int)DGVClients.CurrentRow.Cells[0].Value);

                if(client != null)
                {
                    if(client.DeleteClsClient())
                    {

                        MessageBox.Show("Client Deleted Successfully.", "Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmManageClients_Load(null,null);
                    }
                    else
                    {

                        MessageBox.Show("Client was not deleted because it has data linked to it.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Client is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int AccountNumber = (int)DGVClients.CurrentRow.Cells[0].Value;
            string OperationType = "Deposit";

            Form form = new frmClientsTransactions(AccountNumber, OperationType);
            form.ShowDialog();

            frmManageClients_Load(null, null);  
        }
        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int AccountNumber = (int)DGVClients.CurrentRow.Cells[0].Value;
            string OperationType = "Withdraw";

            Form form = new frmClientsTransactions(AccountNumber, OperationType);
            form.ShowDialog();
            frmManageClients_Load(null, null);  
        }
        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int AccountNumber = (int)DGVClients.CurrentRow.Cells[0].Value;
            string OperationType = "Transfer";

            Form form = new frmClientsTransactions(AccountNumber, OperationType);
            form.ShowDialog();
            frmManageClients_Load(null, null);
        }
   
        //Add Clients 
        public enum enGender { Male = 0, Female = 1 };
        private void _DefaultDataForAdd()
        {

            AddTxtEmail.Text = string.Empty;
            AddTxtFirst.Text = string.Empty;
            AddTxtLast.Text = string.Empty;
            AddTxtSecond.Text = string.Empty;
            AddTxtPhone.Text = string.Empty;
            AddTxtPinCode.Text = string.Empty;
            AddRbMale.Checked = true;
            AddNumberUpBalance.Value = 100;
            AddCBCountries.SelectedItem = "Syria";
            CPBar.Value = 0;
            LbPercent.Text = "0%";

        }
        private void _UpdatePrograssBar()
        {

            Control[] boxes = { AddTxtFirst, AddTxtPinCode, AddTxtLast, AddTxtPhone };

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
        private void _FillingAllCountriesOnComboBox()
        {

            DataTable table = ClsCountry.GetAllCountries();

            foreach (DataRow row in table.Rows)
            {
                AddCBCountries.Items.Add(row["CountryName"]);
                UpCBCountries.Items.Add(row["CountryName"]);
            }

            AddCBCountries.SelectedItem = "Syria";

        }
        private void TxtLeave(object sender, EventArgs e)
        {

            _UpdatePrograssBar();
        }
        private void EmptyTxt(object sender, CancelEventArgs e)
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
        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (AddTxtEmail.Text.Trim() == "")
            {
                errorProvider1.SetError(AddTxtEmail, null);

                return;
            }

            //validate email format
            if (!ClsValidation.ValidateEmail(AddTxtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(AddTxtEmail, "Enter a Correct Email!");
            }
            else
            {
                errorProvider1.SetError(AddTxtEmail, null);
            }

        }
        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(AddTxtPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(AddTxtPhone, "This field is required!");
            }
            else if (AddTxtPhone.Text.Trim().Length != 10)
            {
                e.Cancel = true;
                errorProvider1.SetError(AddTxtPhone, "The phone Number should be ten number..!");

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(AddTxtPhone, null);
            }

        }
        private void TxtLettersKeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }
        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            string Textrequired = string.Empty;

            if (AddTxtFirst.Text.Trim() == string.Empty)
                Textrequired += "First Name";

            if (AddTxtLast.Text.Trim() == string.Empty)
                Textrequired += ", Last Name";

            if (AddTxtPhone.Text.Trim() == string.Empty)
                Textrequired += ", Phone";

            if (AddTxtPinCode.Text.Trim() == string.Empty)
                Textrequired += ", Pin Code";


            if (Textrequired.StartsWith(","))
                Textrequired = Textrequired.Substring(1, Textrequired.Length - 1).Trim();


            if (Textrequired != string.Empty)
            {
                MessageBox.Show($"There are other required fields \n{Textrequired}", "Not Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ClsClient clsClient = new ClsClient();

            clsClient.FirstName = AddTxtFirst.Text;
            clsClient.SecondName = AddTxtSecond.Text;
            clsClient.LastName = AddTxtLast.Text;
            clsClient.PinCode = AddTxtPinCode.Text;
            clsClient.Gender = (AddRbMale.Checked) ? (int)enGender.Male : (int)enGender.Female;
            clsClient.Phone = AddTxtPhone.Text;
            clsClient.Email = AddTxtEmail.Text;
            clsClient.CountryID = ClsCountry.FindByCountryName(AddCBCountries.Text).CountryID;
            clsClient.Balance = AddNumberUpBalance.Value;

            if (clsClient.Save())
            {
                MessageBox.Show($"Data Saved Successfully, Your Account Number = {clsClient.AccountNumber}"
                    , "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmManageClients_Load(null, null);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Update Clients 
        private void _DefaultDataForUpdate()
        {

            UpTxtEmail.Text = string.Empty;
            UpTxtFirst.Text = string.Empty;
            UpTxtLast.Text = string.Empty;
            UpTxtSecond.Text = string.Empty;
            UpTxtPhone.Text = string.Empty;
            UpTxtPinCode.Text = string.Empty;
            UpCBCountries.SelectedIndex = -1;
            UpRbMale.Checked = true;
            UpNumberUpBalance.Value = 0;

        }
        private void _FillingAllAccountNumberOnComboBox()
        {

            CBFindAccountNumber.Items.Clear();
            DataTable table = ClsClient.GetAllClsClients();

            foreach (DataRow row in table.Rows)
            {
                CBFindAccountNumber.Items.Add(row["AccountNumber"]);
            }

        }
        private void CBFindAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

            int AccountNumber = Convert.ToInt32(CBFindAccountNumber.Text);

            ClsClient client = ClsClient.FindByAccountNumber(AccountNumber);

            if (client == null)
            {

                MessageBox.Show("No one has this Acc. Number = " + AccountNumber,
                    "Not Found Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            UpTxtEmail.Text = client.Email;
            UpTxtFirst.Text = client.FirstName;
            UpTxtLast.Text = client.LastName;
            UpTxtSecond.Text = client.SecondName;
            UpTxtPinCode.Text = client.PinCode;
            UpTxtPhone.Text = client.Phone;

            UpCBCountries.SelectedItem = client.CountryInfo.CountryName;
            UpNumberUpBalance.Value = client.Balance;

            if (client.Gender == (int)enGender.Male)
                UpRbMale.Checked = true;
            else
                UpRbFemale.Checked = true;

        }
        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {

            if (CBFindAccountNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Select an account number befor", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            string Textrequired = string.Empty;

            if (UpTxtFirst.Text.Trim() == string.Empty)
                Textrequired += "First Name";

            if (UpTxtLast.Text.Trim() == string.Empty)
                Textrequired += ", Last Name";

            if (UpTxtPhone.Text.Trim() == string.Empty)
                Textrequired += ", Phone";

            if (UpTxtPinCode.Text.Trim() == string.Empty)
                Textrequired += ", Pin Code";


            if (Textrequired.StartsWith(","))
                Textrequired = Textrequired.Substring(1, Textrequired.Length - 1).Trim();

            if (Textrequired != string.Empty)
            {
                MessageBox.Show($"There are other required fields \n{Textrequired}", "Not Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int AccountNumber = Convert.ToInt32(CBFindAccountNumber.Text);
            ClsClient client = ClsClient.FindByAccountNumber(AccountNumber);

            client.FirstName = UpTxtFirst.Text;
            client.SecondName = UpTxtSecond.Text;
            client.LastName = UpTxtLast.Text;
            client.PinCode = UpTxtPinCode.Text;
            client.Email = UpTxtEmail.Text;
            client.Phone = UpTxtPhone.Text;
            client.CountryID = ClsCountry.FindByCountryName(UpCBCountries.Text).CountryID;
            client.Balance = UpNumberUpBalance.Value;
            client.Gender = (UpRbMale.Checked) ? (int)enGender.Male : (int)enGender.Female;

            if (client.Save())
            {

                MessageBox.Show($"Data Saved Successfully"
                    , "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmManageClients_Load(null, null);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
   
    }
}