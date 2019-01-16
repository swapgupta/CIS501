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

    /// <summary>
    /// The returns view for the returns portion of our program.
    /// </summary>
    public partial class CustomerServiceGUI : Form
    {
        // Local CustomerServiceModel
        private CustomerServiceModel csm;
        // Local GetSaleHandler
        private GetSaleHandler gsHan;
        // Local ReturnItemHandler
        private ReturnItemHandler riHan;

        /// <summary>
        /// The constructor for the customer service GUI.
        /// </summary>
        /// <param name="csm">The current working CustomerServiceModel</param>
        /// <param name="gsHan">The GetSaleHandler to be used</param>
        /// <param name="riHan">The ReturnItemHandler to be used</param>
        public CustomerServiceGUI(CustomerServiceModel csm, GetSaleHandler gsHan, ReturnItemHandler riHan)
        {
            InitializeComponent();
            this.csm = csm;
            this.gsHan = gsHan;
            this.riHan = riHan;
            uxItemList.Columns.Add("Item", 90);
            uxItemList.Columns.Add("Quantity", 90);
            uxItemList.Columns.Add("Price", 90);
        }

        /// <summary>
        /// Handles click event on the GetSale button
        /// Uses the GetSaleHandler to get the corresponding sale with the inputted salesID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetSale_Click(object sender, EventArgs e)
        {
                int ID = Convert.ToInt32(uxSalesID.Text);
                gsHan(ID);
        }

        /// <summary>
        /// Handles click event on the ReturnItems button
        /// Uses the ReturnItemHandler to return the items selected from the current sale.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxReturnItems_Click(object sender, EventArgs e)
        {
            if(uxItemList.SelectedItems.Count != 0) riHan(uxItemList.SelectedItems[0].Text, Convert.ToInt32(uxItemQuantity.Value));
        }

        /// <summary>
        /// Handles a click even ton the CompleteReturn button
        /// Exits the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCompleteReturn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Updates this form according to the current CustomerServiceState.
        /// </summary>
        public void update()
        {
            CustomerServiceState state = csm.GetCurrentState();

            switch (state)
            {
                case CustomerServiceState.Initial:
                    MessageBox.Show("Return has begun.");
                    break;
                case CustomerServiceState.InvalidID:
                    MessageBox.Show(csm.Error);
                    break;
                case CustomerServiceState.SuccessfulID:
                    updateItems();
                    break;
                case CustomerServiceState.SuccessfulReturn:
                    Receipt r = new Receipt(csm.GetCurrentSale());
                    r.Show();
                    updateItems();
                    break;
                default:
                    break; 
            }
        }

        /// <summary>
        /// Updates the items in the uxItemList according to what remains in the Sale.
        /// </summary>
        public void updateItems()
        {
            uxItemList.Items.Clear();
            Sale currentSale = csm.GetCurrentSale();

            foreach (Item i in currentSale.GetItems())
            {
                uxItemList.Items.Add(new ListViewItem(new[] { i.Name, i.Quantity.ToString(), String.Format("{0:c}",(i.Price*i.Quantity))}));
            }
        }
    }
}
