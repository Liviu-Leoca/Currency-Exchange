using Proiect_WAP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_WAP
{
    public partial class ExchangeRateForm : Form
    {
        private ExchangeRate _exchangeRate;

        public decimal ExchangeRateValue { get; private set; }

        public ExchangeRateForm()
        {
            InitializeComponent();
        }

        public ExchangeRateForm(decimal exchangeRate) : this()
        {
            ExchangeRateValue = exchangeRate;
        }
        public ExchangeRateForm(ExchangeRate exchangeRate) : this()
        {
            _exchangeRate = exchangeRate;
        }

        private void ExchangeRateForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            Entities.CurrenciesList currenciesList = mainForm.GetCurrenciesList();

            List<Currency> currencyList1 = new List<Currency>(currenciesList.Currencies);
            List<Currency> currencyList2 = new List<Currency>(currenciesList.Currencies);

            comboBox1.DataSource = currencyList1;
            CrsCombo2.DataSource = currencyList2;

            comboBox1.DisplayMember = "Code";
            CrsCombo2.DisplayMember = "Code";
            comboBox1.ValueMember = "Code";
            CrsCombo2.ValueMember = "Code";
        }


        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            Currency selectedCurrency1 = (Currency)comboBox1.SelectedItem;
            Currency selectedCurrency2 = (Currency)CrsCombo2.SelectedItem;

            if (selectedCurrency1 != null && selectedCurrency2 != null)
            {
                decimal exchangeRate = decimal.Parse(ExR.Text);
                _exchangeRate.SetExchangeRate(selectedCurrency1, selectedCurrency2, exchangeRate);
            }
        }
    }
}
