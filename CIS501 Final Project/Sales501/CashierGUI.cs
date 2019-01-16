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
    public delegate void RemoveItemHandler(string itemID, int qty);
    public delegate void AddItemHandler(string itemID, int qty);
    public delegate void CompleteSaleHandler();
    public delegate void CreateSaleHandler(DateTime date);

    /// <summary>
    /// Class for the cashier GUI.
    /// </summary>
    public partial class CashierGUI : Form
    {
        private CashierModel _cashierModel;
        private Dictionary<string, double> _itemsd;
        private RemoveItemHandler _rHan;
        private AddItemHandler _aHan;
        private CompleteSaleHandler _cmHan;
        private CreateSaleHandler _cHan;
        private DateTime date;
        private double _totCost;

        /// <summary>
        /// Initializes the cashier GUI.
        /// </summary>
        /// <param name="cm">An instance of cashier model</param>
        /// <param name="t">The date for the cashier's sales</param>
        /// <param name="rHan">RemoveItemHandler delegate</param>
        /// <param name="aHan">AddItemHandler delegate</param>
        /// <param name="cmHan">CompleteSaleHandler delegate</param>
        /// <param name="cHan">CreateSaleHandler delegate</param>
        public CashierGUI(CashierModel cm, DateTime t, RemoveItemHandler rHan, AddItemHandler aHan, 
                          CompleteSaleHandler cmHan, CreateSaleHandler cHan)
        {
            InitializeComponent();
            _cashierModel = cm;
            _itemsd = _cashierModel.GetItemsForSale();
            uxItems.Columns.Add("Name",93);
            uxItems.Columns.Add("Price", 93);
            uxCart.Columns.Add("Name", 93);
            uxCart.Columns.Add("Quantity", 93);
            uxCart.Columns.Add("Price",92);
            date = t;
            _totCost = 0;

            this._rHan = rHan;
            this._aHan = aHan;
            this._cmHan = cmHan;
            this._cHan = cHan;

            foreach (KeyValuePair<string,double> k in _itemsd)
            {
                uxItems.Items.Add(new ListViewItem(new[] { k.Key, String.Format("{0:c}", k.Value) }));
            }
        }
        
        /// <summary>
        /// Updates the state and performs actions based on it.
        /// </summary>
        public void update()
        {
            CashierState state = _cashierModel.State;
            switch (state)
            {
                case CashierState.Success:
                    Receipt r = new Receipt(_cashierModel.GetCurrentSale());
                    r.Show();

                    uxCart.Items.Clear();
                    uxTotalCost.Text = "Total Cost: $0.00";
                    _cashierModel.State = CashierState.Initial;
                    break;
            }
        }
        /// <summary>
        /// Adds an item to the shopping cart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddItem_Click(object sender, EventArgs e)
        {
            _cHan(date);
            if (uxItems.SelectedItems.Count != 0)
            {
                string name = uxItems.SelectedItems[0].Text;
                string qty = Convert.ToString(uxQuantity.Value);
                double totprice = GetPriceOf(name) * (double)uxQuantity.Value;
                _aHan(name, (int)uxQuantity.Value);
                uxCart.Items.Clear();
                Sale current = _cashierModel.GetCurrentSale();
                _totCost = 0;
                foreach(Item i in current.GetItems())
                {
                    uxCart.Items.Add(new ListViewItem(new[] { i.Name, i.Quantity.ToString(), String.Format("{0:c}", (Convert.ToDouble(i.Price))*i.Quantity) }));
                    _totCost += Convert.ToDouble(i.Price)*i.Quantity;
                }   
                uxTotalCost.Text = "Total Cost = " + String.Format("{0:c}", _totCost);
            }
           
        }
        /// <summary>
        /// Removes an item from the shopping cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRemoveItem_Click(object sender, EventArgs e)
        {
            if (uxCart.SelectedItems.Count != 0)
            {
                this._rHan(uxCart.SelectedItems[0].Text, (int)uxRemoveQuantity.Value);
                uxCart.Items.Clear();
                Sale current = _cashierModel.GetCurrentSale();
                _totCost = 0;
                foreach(Item i in current.GetItems())
                {
                    uxCart.Items.Add(new ListViewItem(new[] { i.Name, i.Quantity.ToString(), String.Format("{0:c}", (Convert.ToDouble(i.Price)) * i.Quantity) }));
                    _totCost += Convert.ToDouble(i.Price) * i.Quantity;
                }
                uxTotalCost.Text = "Total Cost = " + String.Format("{0:c}", _totCost);
            }
        }
        /// <summary>
        /// Gets the priceof an item
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public double GetPriceOf(string name)
        {
            Dictionary<string, double> itemsForSale = _cashierModel.GetItemsForSale();
            return itemsForSale[name];
        }
        /// <summary>
        /// Saves the sale.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCheckout_Click(object sender, EventArgs e)
        {
            if (uxCart.Items.Count == 0)
            {
                MessageBox.Show("You can't checkout with an empty shopping cart.", "Error");
                return;
            }
            _cmHan();
        }
    }
}

