using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    /// <summary>
    /// The rebate controller for the rebate portion of our program.
    /// </summary>
    class RebateController
    {
        // The locally stored Rebate Model.
        private RebateModel _rebateModel;

        /// <summary>
        /// Initializes the RebateController.
        /// </summary>
        /// <param name="rm">The RebateModel inuse.</param>
        public RebateController(RebateModel rm)
        {
            _rebateModel = rm;
        }

        /// <summary>
        /// Handles an entered rebate.
        /// </summary>
        /// <param name="salesID">The saleID of the Sale needing a rebate generated.</param>
        /// <param name="date">The sale's date.</param>
        public void handleEnterRebate(int salesID, DateTime date)
        {
            _rebateModel.GenerateRebate(salesID, date);
            _rebateModel.notify();
        }

        /// <summary>
        /// Handles generating the rebate checks.
        /// </summary>
        /// <param name="salesID">The saleID of the sale needing to be generated.</param>
        public void handleGenerateRebate()
        {
            _rebateModel.GenerateRebateChecks();
            _rebateModel.notify();
        }
    }
}
