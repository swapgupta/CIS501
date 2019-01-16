using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    public delegate void ReturnItemHandler(string item, int qty);
    public delegate void GetSaleHandler(int saleID);

    /// <summary>
    /// The customer service controller for the returns portion of our program.
    /// </summary>
    class CustomerServiceController
    {
        // The local CustomerServiceModel.
        CustomerServiceModel _customerServiceModel;

        /// <summary>
        /// Constructor for the CustomerServiceController
        /// </summary>
        /// <param name="csm">The current CustomerServiceModel</param>
        public CustomerServiceController(CustomerServiceModel csm)
        {
            _customerServiceModel = csm;
            GetSaleHandler gsh = new GetSaleHandler(HandleGetSale);
            ReturnItemHandler rih = new ReturnItemHandler(HandleReturnItem);
        }

        /// <summary>
        /// Handles a return of an item.
        /// </summary>
        /// <param name="item">The name of the item to be returned.</param>
        /// <param name="qty">The amount of the item to be returned.</param>
        public void HandleReturnItem(string item, int qty)
        {
            _customerServiceModel.ReturnItem(item, qty);
            _customerServiceModel.notify();
        }

        /// <summary>
        /// Handles finding the current sale.
        /// </summary>
        /// <param name="saleID">The saleID for the sale we want to return items from.</param>
        public void HandleGetSale(int saleID)
        {
            _customerServiceModel.GetSale(saleID);
            _customerServiceModel.notify();
        }


    }
}
