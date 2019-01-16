using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    /// <summary>
    /// States for the model
    /// </summary>
    public enum CashierState
    {
        Initial,
        Editing,
        Success
    }
    /// <summary>
    /// Model for cashier, controls data.
    /// </summary>
    public class CashierModel : ObservedModel
    {
        public CashierState State { get; set; }

        private Sale _currentSale;
        private SalesDatabase _salesDatabase;
        private static int _currentID = 1;
        /// <summary>
        /// Initalizes cashier model
        /// </summary>
        /// <param name="db">An instance of the salesdatabase</param>
        public CashierModel(SalesDatabase db)
        {
            _salesDatabase = db;
        }

        /// <summary>
        /// Adds an item to the sale
        /// </summary>
        /// <param name="item">Item name</param>
        /// <param name="qty">Number of Items</param>
        public void AddItemToSale(string item, int qty)
        {
            double price = _salesDatabase.GetPriceOf(item);
            _currentSale.AddItem(item, price, qty);
        }

        /// <summary>
        /// Completes a sale.
        /// </summary>
        public void CompleteSale()
        {
            _salesDatabase.Save(_currentID, _currentSale);
            _currentSale.ID = _currentID;
            _currentID++;
            State = CashierState.Success;
            notify();
            CreateSale(_currentSale._date);
        }
        /// <summary>
        /// Creates a sale
        /// </summary>
        /// <param name="date">Sale date</param>
        public void CreateSale(DateTime date)
        {
            if (State != CashierState.Editing)
            {
                Sale sale = new Sale(date);
                _currentSale = sale;
                State = CashierState.Editing;
            }
        }
        /// <summary>
        /// Removes an item from the sale
        /// </summary>
        /// <param name="item">Item name</param>
        /// <param name="qty">Number of items</param>
        public void RemoveItemFromSale(string item, int qty)
        {
            _currentSale.ReturnItem(item, qty);
        }
        /// <summary>
        /// Returns the current sale
        /// </summary>
        /// <returns>The current sale</returns>
        public Sale GetCurrentSale()
        {
            return _currentSale;
        }
        /// <summary>
        /// Cancels the current sale.
        /// </summary>
        public void CancelSale()
        {
            _currentSale = null;
            State = CashierState.Initial;
        }
        /// <summary>
        /// Returns the items available for purchase
        /// </summary>
        /// <returns>A dictionary containing the items available for purchase.</returns>
        public Dictionary<string, double> GetItemsForSale()
        {
            return _salesDatabase.GetItemsForSale();
        }

    }

}
