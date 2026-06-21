using Bank_BussinusLayer;
using Bank_System.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class frmLoginScreen : Form
    {

        ClsUser _User;
        int CountTryLogin = 3;
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void _Login()
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("There are other required fields", "Not Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _User = ClsUser.FindByUserNameAndPassword(TxtUserName.Text.Trim(),
                TxtPassword.Text.Trim());

            if (_User == null)
            {

                CountTryLogin--;

                if (CountTryLogin <= 0)
                {

                    //SaveErrorWithEventLog("The password was typed incorrectly 3 times.");
                    this.Close();
                }

                LbMessaeError.Visible = true;
                LbMessaeError.Text = $"Password is not correct..!\nYou have {CountTryLogin} " +
                    "attempts befor lock your account";

                return;
            }

            if (!_User.IsActive)
            {
                MessageBox.Show("This user is not Active, Contact Admin.");

                return;
            }

            _User.AddNewLogin();
            ClsGlobal.CurrentUser = _User;

            if (CHBRememberMe.Checked)
                ClsGlobal.UploadDataToFile(_User.UserName, _User.Password);
            else
                ClsGlobal.UploadDataToFile();


            LbMessaeError.Visible = false;
            this.Hide();

            Form form = new frmMain(this);
            form.ShowDialog();

        }
        private void _UpdateDateAndTime()
        {

            LbDate.Text = DateTime.Now.ToString("dddd, dd MMM  yyyy");
            LbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void _RemmberMeCheck()
        {

            CHBRememberMe.Checked = true;

            string UserName = "", Password = "";
            ClsGlobal.DownloadDataFromFile(ref UserName, ref Password);

            TxtUserName.Text = UserName;
            TxtPassword.Text = Password;

        }
        private void _UpdateShowPasswordMode()
        {

            if (TxtPassword.PasswordChar == '*')
            {
                TxtPassword.PasswordChar = '\0';
                BtnShowPassword.BackgroundImage = Resources.eye;
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                BtnShowPassword.BackgroundImage = Resources.hidden;

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _UpdateDateAndTime();

        }
        private void SaveErrorWithEventLog(string message)
        {

            string ProjectName = Assembly.GetExecutingAssembly().GetName().Name;

            if (!EventLog.SourceExists(ProjectName))
            {
                EventLog.CreateEventSource(ProjectName, "Application");
            }

            EventLog.WriteEntry(ProjectName, message
                , EventLogEntryType.Warning);
        }
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
            _RemmberMeCheck();
        }
        private void BtnShowPassword_Click(object sender, EventArgs e)
        {

            _UpdateShowPasswordMode();
        }
        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(TxtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtUserName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(TxtUserName, null);
            }

            if (string.IsNullOrEmpty(TxtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtPassword, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(TxtPassword, null);
            }

        }
        private void LLQuestion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show
                ($"You should contact the administration", "Forgotten Password",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            _Login();
        }

    }
}
