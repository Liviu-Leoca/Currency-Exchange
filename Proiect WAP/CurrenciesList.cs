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
    public partial class CurrenciesList : Form
    {
        MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
        
        public CurrenciesList()
        {
            InitializeComponent();
            InitCurrencies();
        }

        private void InitCurrencies()
        {
            Entities.CurrenciesList currenciesList = mainForm.GetCurrenciesList();
            CurrenciesLv.View = View.Details;

            CurrenciesLv.Columns.Add("Name", 200);
            CurrenciesLv.Columns.Add("Code", 80);

            foreach (Currency currency in currenciesList.Currencies)
            {
                ListViewItem item = new ListViewItem(currency.Name);
                item.SubItems.Add(currency.Code);
                item.Tag = currency;
                CurrenciesLv.Items.Add(item);
            }
        }

        private void CurrenciesLv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem selectedItem in CurrenciesLv.SelectedItems)
            {
                var waiter = selectedItem.Tag as Currency;
                if (waiter != null)
                {
                    CurrencyForm form = new CurrencyForm(waiter);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CurrenciesList currencyEditorForm = new CurrenciesList();

                        currencyEditorForm.ShowDialog();
                    }
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CurrenciesLv.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = CurrenciesLv.SelectedItems[0];

                Currency currency = (Currency)selectedItem.Tag;

                mainForm.DeleteCurrency(currency);

                CurrenciesLv.Items.Remove(selectedItem);
                mainForm.PopulateComboBoxes();
            }
        }
    }
}
