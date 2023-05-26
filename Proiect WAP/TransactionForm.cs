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
    public partial class TransactionForm : Form
    {
        private Transaction _transaction;
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public TransactionForm(Transaction currency) : this()
        {
            _transaction = currency;
        }
        private void TransactionForm_Load(object sender, EventArgs e)
        {
            if(_transaction == null)
                _transaction = new Transaction();
            SrsCrs.Text= _transaction.SourceCurrency.Name;
            trgCrs.Text= _transaction.TargetCurrency.Name;
            Amnt.Text= _transaction.Amount.ToString();
            ExRt.Text= _transaction.ExRate.ToString();
            Dat.Text= _transaction.Timestamp.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _transaction.SourceCurrency.Name = SrsCrs.Text;
            _transaction.TargetCurrency.Name = trgCrs.Text;
            _transaction.Amount = decimal.Parse(Amnt.Text);
            _transaction.ExRate = decimal.Parse(ExRt.Text);
            _transaction.Timestamp = DateTime.Parse(Dat.Text);
        }
    }
}
