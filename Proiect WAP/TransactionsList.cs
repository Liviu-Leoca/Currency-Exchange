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
    public partial class TransactionsList : Form
    {
        MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
        public TransactionsList()
        {
            InitializeComponent();
            InitTransactions();
        }

        private void InitTransactions()
        {
            List<Transaction> transactions = mainForm.GetTransactions();
            TransactionsLv.View = View.Details;

            TransactionsLv.Columns.Add("First Currency", 100);
            TransactionsLv.Columns.Add("Second Currency", 100);
            TransactionsLv.Columns.Add("Amount", 100);
            TransactionsLv.Columns.Add("Exchange Rate", 100);
            TransactionsLv.Columns.Add("Date", 100);

            foreach (Transaction transaction in transactions)
            {
                ListViewItem item = new ListViewItem(transaction.SourceCurrency.Code);
                item.SubItems.Add(transaction.TargetCurrency.Code);
                item.SubItems.Add(transaction.Amount.ToString());
                item.SubItems.Add(transaction.ExRate.ToString()); 
                item.SubItems.Add(transaction.Timestamp.ToString()); 
                item.Tag = transaction;
                TransactionsLv.Items.Add(item);
            }
        }

        private void TransactionsLv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem selectedItem in TransactionsLv.SelectedItems)
            {
                var transation = selectedItem.Tag as Transaction;
                if (transation != null)
                {
                    TransactionForm form = new TransactionForm(transation);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        TransactionsList exRateEditorForm = new TransactionsList();

                        exRateEditorForm.ShowDialog();
                    }
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(TransactionsLv.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = TransactionsLv.SelectedItems[0];

                Transaction transaction = (Transaction)selectedItem.Tag;

                mainForm.DeleteTransaction(transaction);

                TransactionsLv.Items.Remove(selectedItem);
                mainForm.PopulateComboBoxes();
            }
        }
    }
}
