using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales501
{
    public partial class Receipt : Form
    {
        private Sale _currentSale;

        public Receipt(Sale s)
        {
            InitializeComponent();

            _currentSale = s;

            uxItemList.Columns.Add("Name", 90);
            uxItemList.Columns.Add("Quantity", 90);
            uxItemList.Columns.Add("Price", 90);

            foreach (Item i in s.GetItems())
            {
                uxItemList.Items.Add(new ListViewItem(new[] { i.Name, i.Quantity.ToString(), String.Format("{0:c}", (Convert.ToDouble(i.Price)) * i.Quantity) }));
            }

            uxDateLabel.Text = s._date.ToString();
            uxSaleIDLabel.Text = "SaleID: " + s.ID.ToString();
            uxSaleTotalLabel.Text = "Sale Total: $" + s.Total().ToString();
        }
    }
}
