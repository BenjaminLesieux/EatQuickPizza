using System;
using EatQuickPizza.Application.Models.Order;

namespace EatQuickPizza.Application.Models.Persons;

public class Client : Person
{
    private readonly string _address;
    public string Address => _address;
    
    private readonly string _phoneNumber;
    public string PhoneNumber => _phoneNumber;

    private readonly DateTime _firstOrder;
    public DateTime FirstOrder => _firstOrder;
    
    public Client(int id, string name, string surname, string address, string phoneNumber, DateTime firstOrder) : base(id, name, surname)
    {
        _address = address;
        _phoneNumber = phoneNumber;
        _firstOrder = firstOrder;
    }

    public override void OnCompleted()
    {
        Console.WriteLine($"Client of id {Id} has received the command and stopped receiving updates");
    }

    public override void OnError(Exception error)
    {
        Console.WriteLine($"It seems like an error has occured with the order of Client {Id}");
        Console.WriteLine(error);
        Console.WriteLine($"Client of id {Id} wont receive any updates anymore");
    }

    public override void OnNext(OrderInfo value)
    {
        if (value.Status == OrderStatus.Created)
        {
            Console.WriteLine("You order has been received");
        }

        if (value.Status == OrderStatus.Closed)
        {
            Console.WriteLine("Enfin");
        }
    }
}