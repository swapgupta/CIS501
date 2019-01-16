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
    public delegate void handleGenerateRebate();
    public delegate void handleEnterRebate(int salesID, DateTime date);

    /// <summary>
    /// The rebate view for the rebate portion of our program.
    /// </summary>
    public partial class RebateGUI : Form
    {
        private RebateModel _rebateModel;
        private handleGenerateRebate _hGR;
        private handleEnterRebate _hER;

        /// <summary>
        /// Constructor for RebateGUI.
        /// </summary>
        /// <param name="rm">RebateModel being used.</param>
        /// <param name="hGR">The GenerateRebate Handler.</param>
        /// <param name="hER">The EnterRebate Handler.</param>
        public RebateGUI(RebateModel rm, handleGenerateRebate hGR, handleEnterRebate hER)
        {
            InitializeComponent();
            _rebateModel = rm;
            _hGR = hGR;
            _hER = hER;

            uxRebateCheckList.Columns.Add("Sales ID");
            uxRebateCheckList.Columns.Add("Total");
            uxRebateCheckList.Columns.Add("Rebate Total");

            uxRebateList.Columns.Add("Sales ID");
            uxRebateList.Columns.Add("Total");
            uxRebateList.Columns.Add("Rebate Total");
        }

        /// <summary>
        /// Update's the output view according to the current state.
        /// </summary>
        public void update()
        {
            RebateModelState state = _rebateModel.GetCurrentState();

            switch (state)
            {
                case RebateModelState.Initial:
                    uxRebateList.Items.Clear();
                    uxRebateCheckList.Items.Clear();
                    break;
                case RebateModelState.RebateGenerated:
                    List<Sale> rebates = _rebateModel.GetUngeneratedRebates();

                    uxRebateList.Items.Clear();
                    foreach(Sale sale in rebates)
                    {
                        uxRebateList.Items.Add(new ListViewItem(new[] { sale.ID.ToString(), String.Format("{0:c}",sale.Total()), String.Format("{0:c}",  sale.RebateAmount) }));
                    }
                    break;
                case RebateModelState.RebateChecksGenerated:
                    MessageBox.Show("Rebate checks generated and sent", "Success");

                    uxRebateList.Items.Clear();
                    uxRebateCheckList.Items.Clear();

                    foreach (Sale sale in _rebateModel.GetGeneratedRebates())
                    {
                        uxRebateCheckList.Items.Add(new ListViewItem(new[] { sale.ID.ToString(), String.Format("{0:c}", sale.Total()), String.Format("{0:c}", sale.RebateAmount) }));
                    }
                    break;
                case RebateModelState.RebateEnterError:
                    MessageBox.Show(_rebateModel.Error);

                    _rebateModel.State = RebateModelState.Initial;
                    update();
                    break;
            }
        }

        /// <summary>
        /// Handles a click event on the GenerateRebate button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGenerateRebate_Click(object sender, EventArgs e)
        {
            _hGR();
        }

        /// <summary>
        /// Handles a click event on the EnterRebate button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEnterRebate_Click(object sender, EventArgs e)
        {
            if (uxSalesID.Text == "")
            {
                MessageBox.Show("Enter a sales ID.", "Error");
                return;
            }

            if (uxDate.Text == "")
            {
                MessageBox.Show("Enter a valid date.", "Error");
            }

            try
            {
                _hER(Convert.ToInt32(uxSalesID.Text), Convert.ToDateTime(uxDate.Text));
            } catch(Exception err)
            {
                MessageBox.Show("Error parsing date. Please try again", "Error");
            }
        }
    }
}
