using System;
using System.Data;
using Bank_BussinusLayer;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        DataTable _dtCountries = ClsCountry.GetAllCountries();

        // Load Data
        private void timer1_Tick(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
        }
        private void _UpdateDateAndTime()
        {

            LbDate.Text = DateTime.Now.ToString("dddd, dd MMM  yyyy");
            LbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void frmCurrencyExchange_Shown(object sender, EventArgs e)
        {

            _UpdateDateAndTime();
            LbUserName.Text = $"Welcom {ClsGlobal.CurrentUser.UserName}";
        }
        private void frmCurrencyExchange_Load(object sender, EventArgs e)
        {

            _FillingAllCountriesOnComboBoxConvertFromAndTo();
            _FillingAllCountriesOnComboBox();

            _dtCountries = ClsCountry.GetAllCountries();

            DGVCountries.DataSource = _dtCountries;
            LbCountRecords.Text = DGVCountries.Rows.Count.ToString();

            if (DGVCountries.Rows.Count > 0)
            {

                DGVCountries.Columns[0].HeaderText = "Country ID";
                DGVCountries.Columns[0].Width = 110;

                DGVCountries.Columns[1].HeaderText = "Country Name";
                DGVCountries.Columns[1].Width = 270;


                DGVCountries.Columns[2].HeaderText = "Country Code";
                DGVCountries.Columns[2].Width = 150;

                DGVCountries.Columns[3].HeaderText = "Currency";
                DGVCountries.Columns[3].Width = 200;
      
                DGVCountries.Columns[4].HeaderText = "Rate";
                DGVCountries.Columns[4].Width = 110;

            }


            _DefaultCurrencyCalculater();
            _DefaultUpdateRate();

        }

        // Show currencies
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

            if (TxtSearch.Text.Trim().Length == 0)
                _dtCountries.DefaultView.RowFilter = "";
            else
                _dtCountries.DefaultView.RowFilter = string.Format("[CountryName] LIKE '{0}%' OR [Code] LIKE '{0}%'", TxtSearch.Text.Trim());


            LbCountRecords.Text = DGVCountries.Rows.Count.ToString();

        }

        // Update Rate
        private void _DefaultUpdateRate()
        {

            LbName.Text = string.Empty;
            LbRate.Text = string.Empty;
            LbCode.Text = string.Empty;

            CBCurrencyCode.Text = string.Empty;
            CBCurrencyCode.SelectedIndex = -1;
            NumberUpNewRate.Value = 0;

        }
        private void _FillingAllCountriesOnComboBox()
        {

            CBCurrencyCode.Items.Clear();
            DataTable table = ClsCountry.GetAllCountryCode();

            foreach (DataRow row in table.Rows)
            {
                CBCurrencyCode.Items.Add(row["Code"]);
            }

        }
        private void CBCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Code = CBCurrencyCode.Text;
            ClsCountry country = ClsCountry.FindByCountryCode(Code);

            LbCode.Text = country.Code;
            LbName.Text = country.Currency;
            LbRate.Text = (country.Rate).ToString()+"$";

            NumberUpNewRate.Value = country.Rate;

        }
        private void BtnUpdateRate_Click(object sender, EventArgs e)
        {

            if (CBCurrencyCode.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Currency code befor", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            string Code = CBCurrencyCode.Text;
            ClsCountry country = ClsCountry.FindByCountryCode(Code);

            if(country.UpdateRateByCountryCode(NumberUpNewRate.Value))
            {

                MessageBox.Show($"Data Saved Successfully"
                    , "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmCurrencyExchange_Load(null, null);

            }

        }

        // Currency Calculator

        private void _DefaultCurrencyCalculater()
        {

            LbCodeConvertFrom.Text = string.Empty;
            LbCodeConvertTo.Text = string.Empty;

            LbNameConvertFrom.Text = string.Empty;
            LbNameConvertTo.Text = string.Empty;

            LbRateConvertFrom.Text = string.Empty;
            LbRateConvertTo.Text = string.Empty;

            CBConvertFrom.Text = string.Empty;
            CBConvertTo.Text = string.Empty;

            CBConvertFrom.SelectedIndex = -1;
            CBConvertTo.SelectedIndex = -1;

            NumericUpAmountExchange.Value = 0;

            LbResult.Text = string.Empty;
            LbResult.Visible = false;

        }
        private void _FillingAllCountriesOnComboBoxConvertFromAndTo()
        {

            CBConvertFrom.Items.Clear();
            CBConvertTo.Items.Clear();

            DataTable table = ClsCountry.GetAllCountryCode();

            foreach (DataRow row in table.Rows)
            {
                CBConvertFrom.Items.Add(row["Code"]);
                CBConvertTo.Items.Add(row["Code"]);
            }

        }
        private void CBConvertFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string Code = CBConvertFrom.Text;
            ClsCountry country = ClsCountry.FindByCountryCode(Code);

            LbCodeConvertFrom.Text = country.Code;
            LbNameConvertFrom.Text = country.CountryName;
            LbRateConvertFrom.Text = country.Rate.ToString();


        }
        private void CBConvertTo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Code = CBConvertTo.Text;
            ClsCountry country = ClsCountry.FindByCountryCode(Code);

            LbCodeConvertTo.Text = country.Code;
            LbNameConvertTo.Text = country.CountryName;
            LbRateConvertTo.Text = country.Rate.ToString();

        }
        private void BtnConvert_Click(object sender, EventArgs e)
        {

            if(CBConvertFrom.SelectedIndex == -1 || CBConvertTo.SelectedIndex == -1)
            {

                MessageBox.Show("Select a country code befor", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            decimal Result = 0;

            if(CBConvertFrom.SelectedText == "USD") //Convert From USD to Any
            {
                Result = NumericUpAmountExchange.Value * (Convert.ToDecimal(LbRateConvertTo.Text));
                LbResult.Text = $"{NumericUpAmountExchange.Value.ToString("N2")} (USD) = {Result.ToString("N2")} ({LbCodeConvertTo.Text})";

            }

            else if(CBConvertTo.SelectedText == "USD") //Convert From any to USD
            {
                Result = NumericUpAmountExchange.Value / (Convert.ToDecimal(LbRateConvertFrom.Text));
                LbResult.Text = $"{NumericUpAmountExchange.Value.ToString("N2")} ({LbCodeConvertFrom.Text}) = {Result.ToString("N2")} (USD)";

            }

            else
            {

                //Convert From any money to USD after than Convert to any
                Result = NumericUpAmountExchange.Value / (Convert.ToDecimal(LbRateConvertFrom.Text)); 
                Result *= (Convert.ToDecimal(LbRateConvertTo.Text));
                LbResult.Text = $"{NumericUpAmountExchange.Value.ToString("N2")} ({LbCodeConvertFrom.Text}) = {Result.ToString("N2")} ({LbCodeConvertTo.Text.ToString()})";

            }

            LbResult.Visible = true;

        }


    }
}
