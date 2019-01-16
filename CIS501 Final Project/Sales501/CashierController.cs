using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    /// <summary>
    /// Handles data flow for cashier
    /// </summary>
    class CashierController
    {
        private CashierModel _cashierModel;
        /// <summary>
        /// Initializes the controller
        /// </summary>
        /// <param name="cm">A Cashier Model instance</param>
         public CashierController (CashierModel cm)
        {
            _cashierModel = cm;
        }
        /// <summary>
        /// Adds an item to the sale.
        /// </summary>
        /// <param name="itemID">Item to be added</param>
        /// <param name="qty">Number of items</param>
        public void handleAddItem(string itemID, int qty)
        {
            _cashierModel.AddItemToSale(itemID, qty);
            _cashierModel.notify();
        }
        /// <summary>
        /// Completes a sale
        /// </summary>
        public void handleCompleteSale()
        {
            _cashierModel.CompleteSale();
            _cashierModel.notify();
        }
        /// <summary>
        /// Creates a sale
        /// </summary>
        /// <param name="date">The date of sale</param>
        public void handleCreateSale(DateTime date)
        {
            _cashierModel.CreateSale(date);
            _cashierModel.notify();
        }
        /// <summary>
        /// Removes an item from the sale
        /// </summary>
        /// <param name="name">Item name</param>
        /// <param name="qty">Number of items</param>
        public void handleRemoveItem(string name, int qty)
        {
            _cashierModel.RemoveItemFromSale(name, qty);
            _cashierModel.notify();
        }
    }
}
