using System;
using System.Data;
using Bank_BussinusLayer;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class frmClientsTransactions : Form
    {

        private static DataTable _dtAllClients = ClsClient.GetAllClsClients();
        private DataTable _dtOnlySelect = _dtAllClients.DefaultView.ToTable(false,"AccountNumber",
                                                                            "PersonFullName", "Balance");

        private static DataTable _dtAllTransferLog = ClsClient.GetAllTransferLogin();
        private DataTable _dtTransferLog = _dtAllTransferLog.DefaultView.ToTable(false, "TransferLogID", "SourseAccountNumber",
                                            "DestinationAccountNumber", "Amount", "TransferDate", "UserName");


        int _SelectedAccountNumber = -1;
        string _OperationType = "";
        public frmClientsTransactions()
        {
            InitializeComponent();
        }
        public frmClientsTransactions(int AccountNumber, string OperationType)
        {

            InitializeComponent();

            _SelectedAccountNumber = AccountNumber;
            _OperationType = OperationType;

            _FillingAllAccountNumberOnComboBoxForDep();
            _FillingAllAccountNumberOnComboBoxForWith();
            _FillingAllAccountNumberOnComboBoxForTransfer();

            switch (OperationType)
            {

                case "Deposit":
                    {
                        TbManageUsers.SelectedTab = TbDeposit;
                        break;
                    }
                case "Withdraw":
                    {
                        TbManageUsers.SelectedTab = TbWithdraw;
                        break;
                    }
                default:
                    {
                        TbManageUsers.SelectedTab = TbTransferBalance;
                        break;
                    }

            }

        }

        private void _UpdateDateAndTime()
        {

            LbDate.Text = DateTime.Now.ToString("dddd, dd MMM  yyyy");
            LbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
        }
        private void frmClientsTransactions_Load(object sender, EventArgs e)
        {

            _FillingAllAccountNumberOnComboBoxForDep();
            _FillingAllAccountNumberOnComboBoxForWith();
            _FillingAllAccountNumberOnComboBoxForTransfer();


            _dtAllClients = ClsClient.GetAllClsClients();
            _dtOnlySelect = _dtAllClients.DefaultView.ToTable(false, "AccountNumber",
                                                                "PersonFullName", "CountryName", "Balance");

            DGVTotalBalance.DataSource = _dtOnlySelect;
            TotalLbCountRecords.Text = DGVTotalBalance.Rows.Count.ToString();
            _SetValueTotalBalance();

            if (DGVTotalBalance.Rows.Count > 0)
            {

                DGVTotalBalance.Columns[0].HeaderText = "Account Number";
                DGVTotalBalance.Columns[0].Width = 140;

                DGVTotalBalance.Columns[1].HeaderText = "Person Full Name";
                DGVTotalBalance.Columns[1].Width = 270;


                DGVTotalBalance.Columns[2].HeaderText = "Country Name";
                DGVTotalBalance.Columns[2].Width = 150;

                DGVTotalBalance.Columns[3].HeaderText = "Balance";
                DGVTotalBalance.Columns[3].Width = 130;

            }

            _dtAllTransferLog = ClsClient.GetAllTransferLogin();
            _dtTransferLog = _dtAllTransferLog.DefaultView.ToTable(false, "TransferLogID", "SourseAccountNumber",
                                            "DestinationAccountNumber", "Amount", "TransferDate", "UserName");


            DGVTransferLog.DataSource = _dtTransferLog;
            LbCountTransferLog.Text = DGVTransferLog.Rows.Count.ToString();

            if (DGVTransferLog.Rows.Count > 0)
            {

                DGVTransferLog.Columns[0].HeaderText = "Transfer ID";
                DGVTransferLog.Columns[0].Width = 110;

                DGVTransferLog.Columns[1].HeaderText = "Source Acc.Number";
                DGVTransferLog.Columns[1].Width = 160;

                DGVTransferLog.Columns[2].HeaderText = "Destination Acc.Number";
                DGVTransferLog.Columns[2].Width = 190;

                DGVTransferLog.Columns[3].HeaderText = "Amount";
                DGVTransferLog.Columns[3].Width = 110;

                DGVTransferLog.Columns[4].HeaderText = "Transfer Date";
                DGVTransferLog.Columns[4].Width = 160;

                DGVTransferLog.Columns[5].HeaderText = "Transfer By";
                DGVTransferLog.Columns[5].Width = 110;

            }

            _DefaltDepositData();
            _DefaltWithdrawData();
            _DefaultTransferData();

        }
        private void frmClientsTransactions_Shown(object sender, EventArgs e)
        {

            _UpdateDateAndTime();

            // Because select index work after draw Combo box

            if (_SelectedAccountNumber == -1)
                return;

            switch (_OperationType)
            {

                case "Deposit":
                    {

                        DepCBFindAccountNumber.SelectedIndex = 
                            DepCBFindAccountNumber.FindStringExact(_SelectedAccountNumber.ToString());
                        
                        break;
                    }
                case "Withdraw":
                    {

                        WithCBFindAccountNumber.SelectedIndex =
                           WithCBFindAccountNumber.FindStringExact(_SelectedAccountNumber.ToString());
                        
                        break;
                    }
                default:
                    {

                        CBSourseBalance.SelectedIndex = 
                            CBSourseBalance.FindStringExact(_SelectedAccountNumber.ToString());

                        break;
                    }

            }
        }

        // Deposit
        private void _DefaltDepositData()
        {

            DepCBFindAccountNumber.SelectedIndex = -1;
            DepLbBalance.Text = "0$";
            DepNumberUpBalance.Value = 0;
        }
        private void _FillingAllAccountNumberOnComboBoxForDep()
        {

            DepCBFindAccountNumber.Items.Clear();
            DataTable table = ClsClient.GetAllClsClients();

            foreach (DataRow row in table.Rows)
            {
                DepCBFindAccountNumber.Items.Add(row["AccountNumber"].ToString());
            }

        }
        private void DepCBFindAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DepCBFindAccountNumber.SelectedIndex == -1)
                return;

            int AccountNumber = Convert.ToInt32(DepCBFindAccountNumber.Text);

            ClsClient client = ClsClient.FindByAccountNumber(AccountNumber);

            DepLbBalance.Text = Convert.ToInt32(client.Balance).ToString() + "$";
        
        }
        private void BtnDeposit_Click(object sender, EventArgs e)
        {

            if (DepCBFindAccountNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Select an account number befor", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            int AccountNumber = Convert.ToInt32(DepCBFindAccountNumber.Text);

            ClsClient client = ClsClient.FindByAccountNumber(AccountNumber);

            if(client.DepositOrWithdrawBalance(DepNumberUpBalance.Value,true))
            {
                MessageBox.Show($"Data Saved Successfully"
                    , "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                frmClientsTransactions_Load(null, null);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        // Withdraw
        private void _DefaltWithdrawData()
        {
            WithCBFindAccountNumber.SelectedIndex = -1;
            WithLbBalance.Text = "0$";
            WithNumberUpBalance.Value = 0;

        }
        private void _FillingAllAccountNumberOnComboBoxForWith()
        {

            WithCBFindAccountNumber.Items.Clear();
            DataTable table = ClsClient.GetAllClsClients();

            foreach (DataRow row in table.Rows)
            {
                WithCBFindAccountNumber.Items.Add(row["AccountNumber"].ToString());
            }

        }
        private void WithCBFindAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (WithCBFindAccountNumber.SelectedIndex == -1)
                return;

            int AccountNumber = Convert.ToInt32(WithCBFindAccountNumber.Text);

            ClsClient client = ClsClient.FindByAccountNumber(AccountNumber);

            if (client.Balance == 0)
            {

                MessageBox.Show("There is no money in this account.", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            WithLbBalance.Text = Convert.ToInt32(client.Balance).ToString() + "$";
            WithNumberUpBalance.Maximum = Convert.ToInt32(client.Balance);

        }
        private void BtnWithdraw_Click(object sender, EventArgs e)
        {

            if (WithCBFindAccountNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Select an account number befor", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }


            int AccountNumber = Convert.ToInt32(WithCBFindAccountNumber.Text);

            ClsClient client = ClsClient.FindByAccountNumber(AccountNumber);

            if(client.Balance < WithNumberUpBalance.Value)
            {
                MessageBox.Show($"You cannot withdrow this amount of money\n Maximum balance is {client.Balance}", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (client.DepositOrWithdrawBalance(WithNumberUpBalance.Value, false))
            {
                MessageBox.Show($"Data Saved Successfully"
                    , "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                frmClientsTransactions_Load(null, null);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        // Total Balance
        private string _NumberToText(long num)
        {

            string[] Arr1To19 = { "", "One", "Two", "Three", "Four", "Five", "Six",
                                "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen",
                                "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen",
                                "Nineteen" };

            string[] Arr20To99 = { "", "", "Twenty", "Thirty", "Forty", "Fifty",
                                    "Sixty", "Seventy", "Eighty", "Ninety" };

            if (num == 0)
            {
                return "Zero";
            }

            if (num >= 1 && num <= 19)
            {
                return Arr1To19[num];
            }

            if (num >= 20 && num <= 99)
            {
                return Arr20To99[num / 10] + (num % 10 > 0 ? "-" + _NumberToText(num % 10) : "");
            }

            if (num >= 100 && num <= 999)
            {
                return _NumberToText(num / 100) + " Hundred" + (num % 100 > 0 ? " " + _NumberToText(num % 100) : "");
            }

            if (num >= 1000 && num <= 999999)
            {
                return _NumberToText(num / 1000) + " Thousand" + (num % 1000 > 0 ? ", " + _NumberToText(num % 1000) : "");
            }

            if (num >= 1000000 && num <= 999999999)
            {
                return _NumberToText(num / 1000000) + " Million" + (num % 1000000 > 0 ? ", " + _NumberToText(num % 1000000) : "");
            }

            if (num >= 1000000000 && num <= 999999999999)
            {
                return _NumberToText(num / 1000000000) + " Billion" + (num % 1000000000 > 0 ? ", " + _NumberToText(num % 1000000000) : "");
            }

            return "";

        }
        private void _SetValueTotalBalance()
        {

            LbNumberBalance.Text = $"({Convert.ToInt32(ClsClient.GetTotalBalance()).ToString()}$)";
            LbTxtBalance.Text = _NumberToText(Convert.ToInt32(ClsClient.GetTotalBalance()));
        }
        private void TotalTxtSearch_TextChanged(object sender, EventArgs e)
        {

            if (TotalTxtSearch.Text.Trim().Length == 0)
                _dtOnlySelect.DefaultView.RowFilter = "";

            TotalLbCountRecords.Text = DGVTotalBalance.Rows.Count.ToString();
        }
        private void TotalBtnFind_Click(object sender, EventArgs e)
        {

            if (TotalTxtSearch.Text.Length > 0)
            {

                _dtOnlySelect.DefaultView.RowFilter = string.Format("[{0}] = {1}", "AccountNumber", TotalTxtSearch.Text.Trim());
                TotalLbCountRecords.Text = DGVTotalBalance.Rows.Count.ToString();
            }

        }

        // Transfer Balance

        enum enTransferOperationType { Deposit = 0, withdraw = 1 };
        private void _DefaultTransferData()
        {
            
            LbSourseBalance.Text = "0$";
            LbDestinationBalance.Text = "0$";
            WithNumberUpBalance.Value = 0;

            CBSourseBalance.SelectedIndex = -1;
            CBDestinationBalance.SelectedIndex = -1;

        }
        private void _FillingAllAccountNumberOnComboBoxForTransfer()
        {

            CBSourseBalance.Items.Clear();
            CBDestinationBalance.Items.Clear();

            DataTable table = ClsClient.GetAllClsClients();

            foreach (DataRow row in table.Rows)
            {
                CBSourseBalance.Items.Add(row["AccountNumber"].ToString());
                CBDestinationBalance.Items.Add(row["AccountNumber"].ToString());
            }

        }
        private void CBSourseBalance_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBSourseBalance.SelectedIndex == -1)
                return;

            int AccountNumber = Convert.ToInt32(CBSourseBalance.Text);

            ClsClient client = ClsClient.FindByAccountNumber(AccountNumber);

            if (client.Balance == 0)
            {

                MessageBox.Show("There is no money in this account.", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            LbSourseBalance.Text = Convert.ToInt32(client.Balance).ToString() + "$";
            NumericAmountTransfer.Maximum = client.Balance; // Maximum value can withdrow it


            string SelectItem = CBSourseBalance.SelectedItem.ToString();

            CBDestinationBalance.Items.Clear();

            DataTable table = ClsClient.GetAllClsClients();

            foreach (DataRow row in table.Rows)
            {
                CBDestinationBalance.Items.Add(row["AccountNumber"].ToString());
            }

            CBDestinationBalance.Items.Remove(SelectItem);
            LbDestinationBalance.Text = "0$";

        }
        private void CBDestinationBalance_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(CBDestinationBalance.SelectedIndex == -1) return;

            int AccountNumber = Convert.ToInt32(CBDestinationBalance.Text);

            ClsClient client = ClsClient.FindByAccountNumber(AccountNumber);
            LbDestinationBalance.Text = Convert.ToInt32(client.Balance).ToString() + "$";

        }
        private bool AddOperationToTransferLog(ClsClient client)
        {
             
            int DestinationAccountNumber = Convert.ToInt32(CBDestinationBalance.Text);

            bool SuccessfulAdd =  client.AddNewTransferLog(DestinationAccountNumber,
                (int)enTransferOperationType.withdraw, NumericAmountTransfer.Value,
                ClsGlobal.CurrentUser.UserID);

            NumericAmountTransfer.Value = 0; // Resert Value

            return SuccessfulAdd;
        }
        private void BtnTransfer_Click(object sender, EventArgs e)
        {

            if (CBDestinationBalance.SelectedIndex == -1 || CBSourseBalance.SelectedIndex == -1)
            {

                MessageBox.Show("Select an account number befor", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            int SourseAccountNumber = Convert.ToInt32(CBSourseBalance.Text);
            int DestinationAccountNumber = Convert.ToInt32(CBDestinationBalance.Text);
            
            ClsClient client = ClsClient.FindByAccountNumber(SourseAccountNumber);
            
            if (client.Balance < NumericAmountTransfer.Value)
            {
                MessageBox.Show($"You cannot withdrow this amount of money\n Maximum balance is {client.Balance}", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }


            if (MessageBox.Show($"Are you sure you want to transfer {NumericAmountTransfer.Value}" +
                $" \n From Acc.Number = {CBSourseBalance.Text} To Acc.Number = {CBDestinationBalance.Text} ", "Confirm transfer",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.No) 
            {

                return;
            }


            
            if(client.TransferBalanceTo(DestinationAccountNumber, NumericAmountTransfer.Value))
            {
                
                if(AddOperationToTransferLog(client))
                {
                    MessageBox.Show($"Data Saved Successfully"
                   , "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmClientsTransactions_Load(null, null);
                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        // Transfer Log
        private void TxtSearchLog_TextChanged(object sender, EventArgs e)
        {

            if (TxtSearchLog.Text.Trim().Length == 0)
                _dtTransferLog.DefaultView.RowFilter = "";
            else
                _dtTransferLog.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Username", TxtSearchLog.Text.Trim());


            LbCountTransferLog.Text = DGVTransferLog.Rows.Count.ToString();

        }

    }
}
