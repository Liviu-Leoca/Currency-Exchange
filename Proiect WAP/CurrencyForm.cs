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
    public partial class CurrencyForm : Form
    {
        private Currency _currency;
        public CurrencyForm()
        {
            InitializeComponent();
        }
        public CurrencyForm(Currency currency) : this()
        {
            _currency = currency;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _currency.Name = CrsName.Text;
            _currency.Code = CrsCode.Text;
        }

        private void CurrencyForm_Load(object sender, EventArgs e)
        {
            if(_currency == null)
                _currency = new Currency();
            CrsName.Text= _currency.Name;
            CrsCode.Text= _currency.Code;
        }
    }
}