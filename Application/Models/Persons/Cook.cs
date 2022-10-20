using EatQuickPizza.Application.Models.Order;

namespace EatQuickPizza.Application.Models.Persons;

public class Cook : Person
{
    public Cook(int id, string name, string surname) : base(id, name, surname)
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
        Console.WriteLine($"{Name} {Surname} has seen the update of {value.Status}");
    }
}