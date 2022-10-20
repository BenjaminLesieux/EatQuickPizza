using EatQuickPizza.Application.Models.Order;

namespace EatQuickPizza.Application.Models.Persons;

public class DeliveryMan : Person
{
    public DeliveryMan(int id, string name, string surname) : base(id, name, surname)
    {
        
    }

    public override void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public override void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public override void OnNext(OrderInfo value)
    {
        throw new NotImplementedException();
    }
}