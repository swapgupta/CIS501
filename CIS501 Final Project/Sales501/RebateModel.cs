using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    /// <summary>
    /// The possible states the Rebate Model can be.
    /// </summary>
    public enum RebateModelState
    {
        Initial,
        RebateGenerated,
        RebateEnterError,
        RebateChecksGenerated
    }

    /// <summary>
    /// The rebate model for the rebate portion of our program.
    /// </summary>
    public class RebateModel : ObservedModel
    {
        // The current Sale
        private Sale _currentSale;
        // Our SalesDatabase object
        private SalesDatabase _salesDatabase;
        // The current RebateModelState of the RebateModel
        public RebateModelState State { get; set; }
        // List of all the generated rebates
        private List<Sale> _rebates;

        /// <summary>
        /// Consturcts the RebateModel
        /// </summary>
        /// <param name="sd">The current in use SalesDatabase</param>
        public RebateModel(SalesDatabase sd)
        {
            _salesDatabase = sd;
            State = RebateModelState.Initial;
            _rebates = new List<Sale>();
        }
        
        /// <summary>
        /// Generates a rebate for the current sale.
        /// </summary>
        /// <param name="salesID">The salesID for the current sale</param>
        /// <param name="date">The entered date.</param>
        public void GenerateRebate(int salesID, DateTime date)
        {
            _currentSale = _salesDatabase.GetSale(salesID);
            DateTime endJuly = new DateTime(2018, 07, 30);

            if (DateTime.Compare(date, endJuly) < 0)
            {
                Error = "Rebate refunds checks are not generated till the end of July!";
                State = RebateModelState.RebateEnterError;
                return;
            }
            if (_currentSale.RebateState == RebateState.Generated)
            {
                Error = "Rebate has already been generated.";
                State = RebateModelState.RebateEnterError;
                return;
            }

            _currentSale.RebateState = RebateState.Rebate;
            State = RebateModelState.RebateGenerated;
            _currentSale.RebateAmount = _currentSale.Total() * 0.11;
        }

        /// <summary>
        /// Returns the list of sales with generated rebates.
        /// </summary>
        /// <returns>The list of sales that have their rebates generated.</returns>
        public List<Sale> GetGeneratedRebates()
        {
            return _rebates;
        }

        /// <summary>
        /// Returns the list of all sales without generated rebates.
        /// </summary>
        /// <returns>The list of sales that haven't had their rebates generated.</returns>
        public List<Sale> GetUngeneratedRebates()
        {
            List<Sale> rebates = new List<Sale>();

            foreach(Sale s in _salesDatabase.AllSales())
            {
                if (s.RebateState == RebateState.Rebate)
                {
                    rebates.Add(s);
                }
            }

            return rebates;
        }

        /// <summary>
        /// Generates a rebate for every sale in our working sale database. 
        /// </summary>
        public void GenerateRebateChecks()
        {
            State = RebateModelState.RebateChecksGenerated;

            foreach (Sale s in _salesDatabase.AllSales())
            {
                if (s.RebateState == RebateState.Rebate)
                {
                    s.RebateState = RebateState.Generated;
                    _rebates.Add(s);
                }
            }
        }

        /// <summary>
        /// Returns the current state of the rebate model.
        /// </summary>
        /// <returns>Current state of the rebate model.</returns>
        public RebateModelState GetCurrentState()
        {
            return State;
        }

        /// <summary>
        /// Returns the current sale being worked on.
        /// </summary>
        /// <returns>Current sale being worked on.</returns>
        public Sale GetCurrentRebate()
        {
            return _currentSale;
        }
    }
}
