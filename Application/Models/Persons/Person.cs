using EatQuickPizza.Application.Models.Order;

namespace EatQuickPizza.Application.Models.Persons;

public abstract class Person: IObserver<OrderInfo>
{
    private IDisposable unsubscriber;
    
    private readonly int _id;
    public int Id => _id;
    
    private readonly string _name;
    public string Name => _name;

    private readonly string _surname;
    public string Surname => _surname;

    protected Person(int id, string name, string surname)
    {
        _id = id;
        _name = name;
        _surname = surname;
    }

    protected void Subscribe(IObservable<OrderInfo> observable)
    {
        observable.Subscribe(this);
    }
    
    protected void Unsubscribe()
    {
        unsubscriber.Dispose();
    }

    public virtual void OnCompleted()
    {
        
    }
    public abstract void OnError(Exception error);

    public abstract void OnNext(OrderInfo value);
}