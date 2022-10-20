using EatQuickApp.Desktop.Application.UI;
using EatQuickPizza.Application.Dao;
using EatQuickPizza.Application.Models.Menu.Pizza;
using EatQuickPizza.Application.Models.Order;
using EatQuickPizza.Application.Models.Persons;
using static System.DateTime;

namespace EatQuickPizza;

public class Program
{
    public static Kitchen Kitchen => InstantiateKitchen();
    
    public static void Main(string[] args)
    {
        Client client = new Client(0, "Lesieux", "Benjamin", "2 rue des champignons", "06424027668", Now);
        Cook cook = new Cook(1, "Lastella", "William");
        Clerk clerk = new Clerk(2, "Molter", "Harold");

        OrderInfo order = new OrderInfo(0);
        order.MenuItems.Add(new PizzaItem(0, PizzaSize.Medium, PizzaType.Margherita));

        order.Subscribe(clerk);
        
        order.UpdateStatus(OrderStatus.Created);
        order.UpdateStatus(OrderStatus.Delivering);
        order.UpdateStatus(OrderStatus.Closed);
    }


    private static Kitchen InstantiateKitchen()
    {
        LoadPersonAssets();
        LoadPizzaAssets();

        Kitchen kitchen = new Kitchen();
        KitchenStaff kitchenStaff = new KitchenStaff(null, null, null, null);
        kitchen.SetKitchenStaff(kitchenStaff);

        return kitchen;
    }

    private static void LoadPizzaAssets()
    {
    }

    private static void LoadPersonAssets()
    {
    }
}