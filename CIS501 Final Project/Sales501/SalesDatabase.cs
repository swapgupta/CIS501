using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sales501
{
    /// <summary>
    /// Class to hold the Sale objects and populate the items for sale.
    /// </summary>
    public class SalesDatabase
    {
        private Dictionary<string, double> _itemsForSale;
        private Dictionary<int, Sale> _sales;

        /// <summary>
        /// Initializes the sales database
        /// </summary>
        public SalesDatabase()
        {
            _sales = new Dictionary<int, Sale>();
            _itemsForSale = new Dictionary<string, double>();
            string[] tokens = Sales501.Properties.Resources.ItemList.Split('\n');
            foreach(string str in tokens)
            {
                string[] itemTokens = str.Split(',');
                _itemsForSale.Add(itemTokens[0], Convert.ToDouble(itemTokens[1].TrimEnd('\\','r')));
            }
           
        }

        /// <summary>
        /// Returns a sale based on the sale id given.
        /// </summary>
        /// <param name="id">The id to be found</param>
        /// <returns>A sale with the matching id</returns>
        public Sale GetSale(int id)
        {
            Sale sale;
            _sales.TryGetValue(id, out sale);
            return sale;
        }

        /// <summary>
        /// Returns a list of all sales.
        /// </summary>
        /// <returns>A list of all sales.</returns>
        public List<Sale> AllSales()
        {
            return _sales.Values.ToList();
        }
        /// <summary>
        /// Saves a sale into the list with it's unique id.
        /// </summary>
        /// <param name="id">The id to be saved as a key</param>
        /// <param name="sale">The sale related to the id</param>
        public void Save(int id, Sale sale)
        {
            _sales[id] = sale;
        }
        /// <summary>
        /// Returns the items available for purchase
        /// </summary>
        /// <returns>Returns a dictionary containing names and prices for available items.</returns>
        public Dictionary<string, double> GetItemsForSale()
        {
            return _itemsForSale;
        }
        /// <summary>
        /// Returns the price of an item
        /// </summary>
        /// <param name="itemName">The item to be searched for</param>
        /// <returns>The price of the item</returns>
        public double GetPriceOf(string itemName)
        {
            return _itemsForSale[itemName];
        }
    }
}
