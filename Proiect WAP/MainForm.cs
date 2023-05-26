using Proiect_WAP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_WAP
{
    public partial class MainForm : Form
    {
        public Entities.ExchangeRatesList _exchangeRatesList = new Entities.ExchangeRatesList();
        public Entities.CurrenciesList _currenciesList = new Entities.CurrenciesList();
        private List<Transaction> transactions = new List<Transaction>();
        private ErrorProvider errorProvider;
        public MainForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
        public Entities.ExchangeRatesList GetExchangeRatesList()
        {
            return _exchangeRatesList;
        }
        public List<Transaction> GetTransactions()
        {
            return transactions;
        }
        public Entities.CurrenciesList GetCurrenciesList()
        {
            return _currenciesList;
        }
        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currency = new Currency();
            CurrencyForm form = new CurrencyForm(currency);
            if (DialogResult.OK == form.ShowDialog())
            {
                _currenciesList.Add(currency);
                PopulateComboBoxes();
            }
        }

        private void exchangeRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exchangeRate = new ExchangeRate();
            ExchangeRateForm form = new ExchangeRateForm(exchangeRate);
            if (DialogResult.OK == form.ShowDialog())
            {
                _exchangeRatesList.Add(exchangeRate);
            }
        }
        public void PopulateComboBoxes()
        {
            Entities.CurrenciesList currenciesList = GetCurrenciesList();

            List<Currency> currencyList1 = new List<Currency>(currenciesList.Currencies);
            List<Currency> currencyList2 = new List<Currency>(currenciesList.Currencies);

            comboBox1.DataSource = currencyList1;
            comboBox2.DataSource = currencyList2;

            comboBox1.DisplayMember = "Code";
            comboBox2.DisplayMember = "Code";
            comboBox1.ValueMember = "Code";
            comboBox2.ValueMember = "Code";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();

           
            contextMenuStrip1.Items.Add("Add");
            contextMenuStrip1.Items.Add("Edit");
            contextMenuStrip1.Items.Add("File");
        }

        public void DeleteCurrency(Currency currency)
        {
            _currenciesList.Currencies.Remove(currency);
        }
        public void DeleteExchangeRate(ExchangeRate exRate)
        {
            _exchangeRatesList.ExchangeRates.Remove(exRate);
        }
        public void DeleteTransaction(Transaction transaction)
        {
            transactions.Remove(transaction);
        }
        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            Currency sourceCurrency = (Currency)comboBox1.SelectedItem;
            Currency targetCurrency = (Currency)comboBox2.SelectedItem;
            decimal amount = decimal.Parse(AmountBox.Text);
            DateTime transactionDate = DateTime.Now;
            try
            {
                decimal exchangeRate = GetExchangeRate(sourceCurrency, targetCurrency);

                decimal convertedAmount = amount * exchangeRate;

                Transaction transaction = new Transaction(sourceCurrency, targetCurrency, amount, exchangeRate, transactionDate);

                transactions.Add(transaction);
                ResultTxtBox.Text = convertedAmount.ToString();
                StatusStripMF.Text = $"Amount Converted: {convertedAmount}";

                MessageBox.Show("Conversion completed successfully.", "Conversion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the conversion: {ex.Message}", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal GetExchangeRate(Currency sourceCurrency, Currency targetCurrency)
        {
            Currency innerSourceCurrency = comboBox1.SelectedItem as Currency;
            Currency innertargetCurrency = comboBox2.SelectedItem as Currency;

            ExchangeRate exchangeRate = _exchangeRatesList.Find(innerSourceCurrency, targetCurrency);

            if (exchangeRate != null)
            {
                return exchangeRate.Rate;
            }
            else
            {
                throw new Exception($"Exchange rate not found for {sourceCurrency.Code} to {targetCurrency.Code}.");
            }
        }

        private void serializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = File.OpenWrite("Currencies.bin"))
            {
                formatter.Serialize(f, _currenciesList);
            }
            using (FileStream f = File.OpenWrite("ExchangeRates.bin"))
            {
                formatter.Serialize(f, _exchangeRatesList);
            }
        }

        private void deserializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream f = null;
            try
            {
                f = File.OpenRead("Currencies.bin");
                _currenciesList = (Entities.CurrenciesList)formatter.Deserialize(f);
                PopulateComboBoxes();
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                if (f != null)
                    f.Close();
            }
            FileStream g = null;
            try
            {
                g = File.OpenRead("ExchangeRates.bin");
                _exchangeRatesList = (Entities.ExchangeRatesList)formatter.Deserialize(g);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                if (g != null)
                    g.Close();
            }
        }

        private void currenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrenciesList currencyEditorForm = new CurrenciesList();

            currencyEditorForm.ShowDialog();
        }

        private void exchangeRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExchangeRatesList exRatesEditorForm = new ExchangeRatesList();

            exRatesEditorForm.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionsList transactionsEditorForm = new TransactionsList();

            transactionsEditorForm.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            ToolStripMenuItem fileMenuItem1 = new ToolStripMenuItem("File");
            fileMenuItem1.ShortcutKeys = Keys.Alt | Keys.F;
            ToolStripMenuItem fileMenuItem2 = new ToolStripMenuItem("Add");
            fileMenuItem2.ShortcutKeys = Keys.Alt | Keys.A;
            ToolStripMenuItem fileMenuItem3 = new ToolStripMenuItem("Edit");
            fileMenuItem1.ShortcutKeys = Keys.Alt | Keys.E;
        }

        private void AmountBox_Validating(object sender, CancelEventArgs e)
        {
            decimal amount;
            if (!decimal.TryParse(AmountBox.Text, out amount) || amount <= 0)
            {
                errorProvider.SetError(AmountBox, "Please enter a valid amount.");
                e.Cancel = true;
            }
        }
        private void ExportTransactions(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Transaction transaction in transactions)
                    {
                        writer.WriteLine($"Source Currency: {transaction.SourceCurrency.Code}");
                        writer.WriteLine($"Target Currency: {transaction.TargetCurrency.Code}");
                        writer.WriteLine($"Amount: {transaction.Amount}");
                        writer.WriteLine($"Exchange Rate: {transaction.ExRate}");
                        writer.WriteLine($"Date: {transaction.Timestamp}");
                        writer.WriteLine();
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error exporting transactions: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            string filepath = "TransactionsReport.txt";
            ExportTransactions(filepath);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}