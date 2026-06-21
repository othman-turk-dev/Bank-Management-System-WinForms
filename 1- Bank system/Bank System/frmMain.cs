using System;
using Bank_BussinusLayer;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class frmMain : Form
    {

        frmLoginScreen _frmLogin;
        enum enPermissions
        {
            eAll = -1, pManageClients = 1, pManageUser = 2, pCurrencyExchange = 4,
            pClientsTransactions = 8
        };

        public frmMain(frmLoginScreen frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
        }

        private void _UpdateDateAndTime()
        {

            LbDate.Text = DateTime.Now.ToString("dddd, dd MMM  yyyy");
            LbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private bool _CheckAccessPermission(enPermissions Permission)
        {

            if (ClsGlobal.CurrentUser.Permissons == (int)enPermissions.eAll)
                return true;

            if (((int)Permission & ClsGlobal.CurrentUser.Permissons) == (int)Permission)
                return true;
            else
                return false;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
            LbUserName.Text = $"Welcom {ClsGlobal.CurrentUser.UserName}";

        }
        private void BtnManageClients_Click(object sender, EventArgs e)
        {

            if(!_CheckAccessPermission(enPermissions.pManageClients))
            {
                BtnManageClients.Enabled = false;
                return;
            }

            Form form = new frmManageClients();
            form.ShowDialog();

        }
        private void BtnManageUsers_Click(object sender, EventArgs e)
        {

            if (!_CheckAccessPermission(enPermissions.pManageUser))
            {
                BtnManageUsers.Enabled = false;
                return;
            }

            Form form = new frmManageUsers();
            form.ShowDialog();

        }
        private void BtnClientsTransactions_Click(object sender, EventArgs e)
        {

            if (!_CheckAccessPermission(enPermissions.pClientsTransactions))
            {
                BtnClientsTransactions.Enabled = false;
                return;
            }

            Form form = new frmClientsTransactions();
            form.ShowDialog();

        }
        private void BtnCurrencyExchange_Click(object sender, EventArgs e)
        {

            if (!_CheckAccessPermission(enPermissions.pCurrencyExchange))
            {
                BtnCurrencyExchange.Enabled = false;
                return;
            }

            Form form = new frmCurrencyExchange();
            form.ShowDialog();

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {

            ClsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

    }
}
