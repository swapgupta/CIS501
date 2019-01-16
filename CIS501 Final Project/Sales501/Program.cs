using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Sales501
{
    public delegate void Observer();

    class Program
    {
        static void Main(string[] args)
        {
            SalesDatabase db = new Sales501.SalesDatabase();

            Console.WriteLine("\n  1) Cashier GUI \n");
            Console.WriteLine("  2) Customer Service \n");
            Console.WriteLine("  3) Rebate \n");
            Console.WriteLine("  4) Console GUI \n");
            Console.WriteLine("  5) Quit \n");
            Console.WriteLine("------------------");

            char a = '0';

            while (a != '5')
            {
                Console.Write("Select an option: ");
                a = Console.ReadLine()[0];

                switch(a)
                {
                    case '1':
                        Console.Write("\nEnter the date(MM/DD): ");
                        DateTime date = new DateTime();
                        bool successfulDate = false;

                        while(!successfulDate)
                        {
                            try
                            {
                                date = Convert.ToDateTime(Console.ReadLine());
                                successfulDate = true;
                            } catch(Exception err)
                            {
                                Console.WriteLine("Enter a valid date.");
                            }
                        }

                        CashierModel cm = new CashierModel(db);
                        CashierController cc = new CashierController(cm);
                        CashierGUI cg = new CashierGUI(cm, date, cc.handleRemoveItem, cc.handleAddItem,
                                                       cc.handleCompleteSale, cc.handleCreateSale);
                        cm.register(cg.update);
                        var t = new Thread(() => cashGUI(cg));
                        t.Start();
                        break;
                    case '2':
                        CustomerServiceModel csm = new CustomerServiceModel(db);
                        CustomerServiceController csc = new CustomerServiceController(csm);
                        CustomerServiceGUI csGUI = new CustomerServiceGUI(csm, csc.HandleGetSale, csc.HandleReturnItem);
                        csm.register(csGUI.update);
                        var r = new Thread(() => servGUI(csGUI));
                        r.Start();
                        break;
                    case '3':
                        RebateModel rm = new RebateModel(db);
                        RebateController rc = new RebateController(rm);
                        RebateGUI rGUI = new RebateGUI(rm, rc.handleGenerateRebate, rc.handleEnterRebate);
                        rm.register(rGUI.update);
                        var re = new Thread(() => rebateGUI(rGUI));
                        re.Start();
                        break;
                    case '4':
                        ConsoleGUI(db);
                        Console.Clear();
                        Console.WriteLine("\n  1) Cashier GUI \n");
                        Console.WriteLine("  2) Customer Service \n");
                        Console.WriteLine("  3) Rebate \n");
                        Console.WriteLine("  4) Console GUI \n");
                        Console.WriteLine("  5) Quit \n");
                        Console.WriteLine("------------------");
                        break;
                    case '5':
                        Application.Exit();
                        break;
                    default:
                        Console.WriteLine("Enter a number 1-5 \n");
                        a = Console.ReadLine()[0];
                        break;
                }
            }
        }
        static void cashGUI(CashierGUI cg)
        {
            Application.Run(cg);
        }
        static void servGUI(CustomerServiceGUI csGUI)
        {
            Application.Run(csGUI);
        }
        static void rebateGUI(RebateGUI rGUI)
        {
            Application.Run(rGUI);
        }

        /// <summary>
        /// Runs the ConsoleGUI
        /// </summary>
        /// <param name="db">the sales database</param>
        static void ConsoleGUI(SalesDatabase db)
        {
            Console.Clear();

            Console.WriteLine("\n  1) Create Sale Transaction \n");
            Console.WriteLine("  2) Return Item \n");
            Console.WriteLine("  3) Rebate Request \n");
            Console.WriteLine("  4) Generate Rebate \n");
            Console.WriteLine("  5) Quit \n");
            Console.WriteLine("------------------");

            char a = '0';

            RebateModel rm = null;
            RebateController rc = null;

            while (a != '5')
            {
                Console.Write("\n\nSelect an option: ");
                a = Console.ReadLine()[0];

                switch (a)
                {
                    case '1':
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
                        CashierModel cm = new CashierModel(db);
                        CashierController cc = new CashierController(cm);
                        ConsoleGUI sales = new ConsoleGUI(cm, date, cc.handleRemoveItem, cc.handleAddItem,
                                                       cc.handleCompleteSale, cc.handleCreateSale);
                        sales.ListItems();
                        sales.AddItem();
                        break;
                    case '2':
                        CustomerServiceModel csm = new CustomerServiceModel(db);
                        CustomerServiceController csc = new CustomerServiceController(csm);
                        ConsoleGUI sc = new ConsoleGUI(csm, csc.HandleGetSale, csc.HandleReturnItem);
                        sc.ReturnItem();
                        break;
                    case '3':
                        rm = new RebateModel(db);
                        rc = new RebateController(rm);
                        ConsoleGUI rebate = new ConsoleGUI(rm, rc.handleGenerateRebate, rc.handleEnterRebate);
                        rebate.Rebate();
                        break;
                    case '4':
                        try
                        {
                            ConsoleGUI grebate = new ConsoleGUI(rm, rc.handleGenerateRebate, rc.handleEnterRebate);
                            grebate.GenerateRebate();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Request Rebates first!");
                        }
                        break;
                    case '5':
                        break;
                    default:
                        Console.WriteLine("Enter a number 1-5 \n");
                        a = Console.ReadLine()[0];
                        break;
                }
            }

        }
    }

}
