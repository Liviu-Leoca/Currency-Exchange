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
    public partial class ExchangeRatesList : Form
    {
        MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
        public ExchangeRatesList()
        {
            InitializeComponent();
            InitExchangeRates();
        }
        private void InitExchangeRates()
        {
            Entities.ExchangeRatesList exchangeRatesList = mainForm.GetExchangeRatesList();
            ExchangeRatesLv.View = View.Details;

            ExchangeRatesLv.Columns.Add("First Currency", 100);
            ExchangeRatesLv.Columns.Add("Second Currency", 100);
            ExchangeRatesLv.Columns.Add("Rate", 80);

            foreach (ExchangeRate exchangeRate in exchangeRatesList.ExchangeRates)
            {
                ListViewItem item = new ListViewItem(exchangeRate.SourceCurrency.Code);
                item.SubItems.Add(exchangeRate.TargetCurrency.Code);
                item.SubItems.Add(exchangeRate.Rate.ToString());
                item.Tag = exchangeRate;
                ExchangeRatesLv.Items.Add(item);
            }
        }

        private void ExchangeRatesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ExchangeRatesLv.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ExchangeRatesLv.SelectedItems[0];

                ExchangeRate exRate = (ExchangeRate)selectedItem.Tag;

                mainForm.DeleteExchangeRate(exRate);

                ExchangeRatesLv.Items.Remove(selectedItem);
            }
        }

        private void ExchangeRatesLv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem selectedItem in ExchangeRatesLv.SelectedItems)
            {
                var exRate = selectedItem.Tag as ExchangeRate;
                if (exRate != null)
                {
                    ExchangeRateForm form = new ExchangeRateForm(exRate);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        ExchangeRatesList exRateEditorForm = new ExchangeRatesList();

                        exRateEditorForm.ShowDialog();
                    }
                }
            }
        }
    }
}
