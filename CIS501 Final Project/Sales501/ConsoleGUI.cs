using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    class ConsoleGUI
    {
        private CashierModel _cm;
        private RemoveItemHandler _rHan;
        private AddItemHandler _aHan;
        private CompleteSaleHandler _cmHan;
        private CreateSaleHandler _cHan;
        private SalesDatabase _sdb;
        private DateTime _date;

        private CustomerServiceModel _csm;
        private GetSaleHandler _gsHan;
        private ReturnItemHandler _riHan;

        private RebateModel _rm;
        private handleGenerateRebate _hGR;
        private handleEnterRebate _hER;

        /// <summary>
        /// Constructor with sales database
        /// </summary>
        /// <param name="sdb"></param>
        public ConsoleGUI(SalesDatabase sdb)
        {
            _sdb = sdb;
        }

        /// <summary>
        /// Constructor for console cashier
        /// </summary>
        /// <param name="cm"></param>
        /// <param name="t"></param>
        /// <param name="rHan"></param>
        /// <param name="aHan"></param>
        /// <param name="cmHan"></param>
        /// <param name="cHan"></param>
        public ConsoleGUI(CashierModel cm, DateTime t, RemoveItemHandler rHan, AddItemHandler aHan,
                          CompleteSaleHandler cmHan, CreateSaleHandler cHan)
        {
            _cm = cm;
            _rHan = rHan;
            _aHan = aHan;
            _cmHan = cmHan;
            _cHan = cHan;
            _date = t;
        }

        /// <summary>
        /// Constructor for console customer service
        /// </summary>
        /// <param name="csm"></param>
        /// <param name="gsHan"></param>
        /// <param name="riHan"></param>
        public ConsoleGUI(CustomerServiceModel csm, GetSaleHandler gsHan, ReturnItemHandler riHan)
        {
            _csm = csm;
            _gsHan = gsHan;
            _riHan = riHan;
        }

        /// <summary>
        /// Constructor for console rebates
        /// </summary>
        /// <param name="rm"></param>
        /// <param name="hGR"></param>
        /// <param name="hER"></param>
        public ConsoleGUI(RebateModel rm, handleGenerateRebate hGR, handleEnterRebate hER)
        {
            _rm = rm;
            _hGR = hGR;
            _hER = hER;
        }

        /// <summary>
        /// Prints out Items for sale
        /// </summary>
        public void ListItems()
        {
            Console.WriteLine("Items for sale: ");
            Console.WriteLine("\nItem\t\tPrice");
            
            foreach (KeyValuePair<string, double> kvp in _cm.GetItemsForSale())
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine("{0}\t{1}", kvp.Key, kvp.Value.ToString("C"));
            }
        }

        /// <summary>
        /// Adds items to a sale and adds the sale to the sales database
        /// </summary>
        public void AddItem()
        {
            _cHan(_date);
            Dictionary<string, double> items = _cm.GetItemsForSale();
            Console.Write("Enter the item and quantity seperated by a comma(,): ");
            string[] item = Console.ReadLine().Split(',');
            if (items.ContainsKey(item[0]))
            {
                int quantity = 0;
                int.TryParse(item[1], out quantity);
                _aHan(item[0], quantity);
            }
            Sale curSale = _cm.GetCurrentSale();
            List<Item> curItems = null;
            while (item[0][0] != 'C')
            {
                try
                {
                    curItems = curSale.GetItems();
                    Console.Write("\nName\tQuantity\tPrice");
                    foreach (Item i in curItems)
                    {
                        Console.Write("\n{0}\t{1}\t{2}", i.Name, i.Quantity, i.Price.ToString("C"));
                    }
                    Console.Write("\nEnter the next item and quantity, ");
                    Console.Write("\nenter 'R' to remove a item, ");
                    Console.Write("\nenter 'C' to checkout: ");
                    item = Console.ReadLine().Split(',');
                    switch (item[0])
                    {
                        case "C":
                            _cmHan();
                            curItems = curSale.GetItems();
                            Console.Write("\nName\tQuantity\tPrice");
                            foreach (Item i in curItems)
                            {
                                Console.Write("\n{0}\t{1}\t{2}", i.Name, i.Quantity, i.Price.ToString("C"));
                            }
                            Console.WriteLine("\nSales ID: {0}", curSale.ID);
                            Console.WriteLine("\nTotal: {0}", curSale.Total().ToString("C"));
                            break;
                        case "R":
                            Console.Write("\nEnter the item and quantity to remove seperated by a comma(,): ");
                            item = Console.ReadLine().Split(',');
                            _rHan(item[0], Convert.ToInt32(item[1]));
                            break;
                        default:
                            if (items.ContainsKey(item[0]))
                            {
                                int quantity = 0;
                                int.TryParse(item[1], out quantity);
                                _aHan(item[0], quantity);
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Entry");
                }
                
            }

        }

        /// <summary>
        /// Used to return items
        /// </summary>
        public void ReturnItem()
        {
            CustomerServiceState state = _csm.GetCurrentState();
            string[] returnItem = null;
            bool valid = false;
            int ID = 0;
            while (!valid)
            {
                Console.Write("Enter the Sales ID: ");
                valid = int.TryParse(Console.ReadLine(), out ID);
            }
            
            Sale currentSale;
            List<Item> items = null;

            while (state != CustomerServiceState.SuccessfulReturn)
            {
                switch (state)
                {
                    case CustomerServiceState.Initial:
                        _gsHan(ID);
                        state = _csm.GetCurrentState();
                        break;
                    case CustomerServiceState.InvalidID:
                        Console.WriteLine("Invalid ID");
                        Console.Write("\nEnter the Sales ID: ");
                        ID = Convert.ToInt32(Console.ReadLine());
                        state = _csm.GetCurrentState();
                        break;
                    case CustomerServiceState.SuccessfulID:
                        currentSale = _csm.GetCurrentSale();
                        items = currentSale.GetItems();
                        Console.Write("\nName\tQuantity\tPrice");
                        foreach (Item i in items)
                        {
                            Console.Write("\n{0}\t{1}\t\t{2}", i.Name, i.Quantity, i.Price.ToString("C"));
                        }
                        Console.Write("\nEnter the item and quantity to return seperated by a comma(,): ");
                        returnItem = Console.ReadLine().Split(',');
                        foreach(Item i in items)
                        {
                            if (i.Name.Equals(returnItem[0]))
                            {
                                int quantity = 0;
                                int.TryParse(returnItem[1], out quantity);
                                _riHan(returnItem[0], quantity);
                                break;
                            }
                        }
                        
                        state = _csm.GetCurrentState();
                        break;
                    default:
                        break;
                }
            }
            Console.Write("\nName\tQuantity\tPrice");
            foreach (Item i in items)
            {
                Console.Write("\n{0}\t{1}\t\t{2}", i.Name, i.Quantity, i.Price.ToString("C"));
            }
            Console.WriteLine("\nReturn successful.\n");
        }

        /// <summary>
        /// Used to request rebates
        /// </summary>
        public void Rebate()
        {
            bool valid = false;
            int ID = 0;
            while (!valid)
            {
                Console.Write("Enter the Sales ID: ");
                valid = int.TryParse(Console.ReadLine(), out ID);
            }
            Console.Write("\nEnter the date(MM/DD): ");
            DateTime date = new DateTime();
            bool successfulDate = false;

            while (!successfulDate)
            {
                try
                {
                    date = Convert.ToDateTime(Console.ReadLine());
                    successfulDate = true;
                }
                catch (Exception err)
                {
                    Console.WriteLine("Enter a valid date.");
                }
            }
            bool rebateBool = false;
            while(!rebateBool)
            {
                try
                {
                    _hER(ID, date);
                    rebateBool = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("\nEnter valid ID: ");
                    int.TryParse(Console.ReadLine(), out ID);
                }
            }
            
            if(_rm.GetCurrentState() != RebateModelState.RebateEnterError)
            {
                Console.Write("\nSales ID\tTotal\tRebate Amount\n");
                List<Sale> rebates = _rm.GetUngeneratedRebates();
                foreach (Sale s in rebates)
                {
                    double total = s.Total();
                    Console.Write("\n{0}\t\t{1}\t\t{2}", s.ID, total.ToString("C"), s.RebateAmount.ToString("C"));
                }
                Console.WriteLine("\nRebates requested.");
            }
            else
            {
                Console.WriteLine("There was an error. {0}", _rm.Error);
            }
        }

        /// <summary>
        /// Used to generate rebates
        /// </summary>
        public void GenerateRebate()
        {
            _hGR();
            Console.Write("\nSales ID\tTotal\tRebate Amount\n");
            List<Sale> rebates = _rm.GetGeneratedRebates();
            foreach (Sale s in rebates)
            {
                double total = s.Total();
                Console.Write("\n{0}\t\t{1}\t\t{2}", s.ID, total.ToString("C"), s.RebateAmount.ToString("C"));
            }
            Console.WriteLine("\nRebates generated.");
        }

    }
}
