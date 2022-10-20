using System;

namespace EatQuickApp.Desktop.Application.UI;

public class MainMenu : IMenu
{
    public void Start()
    {
        Console.WriteLine("Launching the start menu...");
        
        while (true)
        {
            Console.WriteLine("----- EatQuickPizzeria -----");
            Console.WriteLine(@"Choose your module : 
                                
                               1. Client/Staff module
                               2. Order module
                               3. Stats module
                               4. Order a pizza ");

            var response = Console.Read();
            IMenu menu;

            switch (response)
            {
                case 1:
                {
                    menu = new ClientStaffMenu();
                    menu.Start();
                    break;
                }

                case 2:
                {
                    menu = new OrderMenu();
                    menu.Start();
                    break;
                }

                case 3:
                {
                    menu = new StatsModule();
                    menu.Start();
                    break;
                }

                case 4:
                {
                    menu = new OrderPizzaMenu();
                    menu.Start();
                    break;
                }
            }
        }
    }
}