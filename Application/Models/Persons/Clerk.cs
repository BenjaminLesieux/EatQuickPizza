using EatQuickPizza.Application.Dao;
using EatQuickPizza.Application.Models.Order;

namespace EatQuickPizza.Application.Models.Persons;

public class Clerk : Person
{
    public Clerk(int id, string name, string surname) : base(id, name, surname)
    {
        
    }

    public override void OnCompleted()
    {
        
    }

    public override void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public override async void OnNext(OrderInfo value)
    {
        switch (value.Status)
        {
            case OrderStatus.Created:
            {
                await Task.Run(() => Program.Kitchen.SendOrderToKitchen(value));
                break;
            }
        }
    }
}