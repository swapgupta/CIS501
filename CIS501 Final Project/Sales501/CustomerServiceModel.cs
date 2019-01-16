using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    /// <summary>
    /// The possible states the Customer Service Model can be.
    /// </summary>
    public enum CustomerServiceState
    {
        Initial, 
        InvalidID,
        SuccessfulID,
        SuccessfulReturn
    }

    /// <summary>
    /// The customer service model for the returns portion of our program.
    /// </summary>
    public class CustomerServiceModel : ObservedModel
    {
        // The current working SalesDatabse.
        private SalesDatabase sd;
        // The current CustomerServiceState of the CustomerServiceModel
        private CustomerServiceState state { get; set; }
        // The current sale
        private Sale currentSale;

        /// <summary>
        /// The constructor for the CustomerServiceModel.
        /// </summary>
        /// <param name="sd">The current working SalesDatabase.</param>
        public CustomerServiceModel (SalesDatabase sd)
        {
            this.sd = sd;
            state = CustomerServiceState.Initial;
        } 

        /// <summary>
        /// Returns the current CustomerServiceState
        /// </summary>
        /// <returns>The current CustomerServiceState</returns>
        public CustomerServiceState GetCurrentState()
        {
            return state;
        }

        /// <summary>
        /// Returns an item from a sale.
        /// </summary>
        /// <param name="item">The item to be returned from the sale.</param>
        /// <param name="qty">The amount of the item to be returned.</param>
        public void ReturnItem (string item, int qty)
        {
            currentSale.ReturnItem(item, qty);
            state = CustomerServiceState.SuccessfulReturn;
        }

        /// <summary>
        /// Returns the current sale.
        /// </summary>
        /// <returns>The current sale being worked on</returns>
        public Sale GetCurrentSale()
        {
            return currentSale;
        }

        /// <summary>
        /// Find the sale corresponding with the saleID.
        /// </summary>
        /// <param name="saleID">The saleID corresponding with the Sale we want to work on</param>
        public void GetSale (int saleID)
        {
            currentSale = sd.GetSale(saleID);
            if (currentSale != null)
            {
                state = CustomerServiceState.SuccessfulID;
            }
            else
            {
                this.Error = "Invalid Sale ID.";
                state = CustomerServiceState.InvalidID;
            }
        }
    }
}
