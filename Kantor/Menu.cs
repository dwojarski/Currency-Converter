using System;

namespace Kantor
{
    class Menu
    {
        public Menu()
        {
            Console.WriteLine("Welcome to Currency-Exchange application!");
            this.ShowMenu();
            Connection connect = new Connection();
            IParser xmlParser = new ParserXml(connect.getUrl());
            Repository rep = xmlParser.Parse();
            int choice = 0;
            while (true)
            {
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ShowData data = new ShowData();
                        data.DisplayData(rep.GetCurrencyList());
                        break;
                    case 2:
                        ExchangePanel exchange = new ExchangePanel();
                        exchange.Transaction(rep.GetCurrencyList());
                        break;
                    case 3:
                        this.ApplicationTerminated();
                        break;
                    default:
                        Console.WriteLine("Unknown option... Please try again!\n");                        
                        break;
                }
                this.ShowMenu();
            }
        }
        public void ShowMenu()
        {
            Console.WriteLine("\nPress:");
            Console.WriteLine("1 - to display all currencies");
            Console.WriteLine("2 - to exchange two different currencies");
            Console.WriteLine("3 - to close application");
        }
        public void ApplicationTerminated()
        {
            Console.WriteLine("Exiting program...");
            Environment.Exit(0);
        }
    }
}
