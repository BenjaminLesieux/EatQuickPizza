using EatQuickPizza.Application.Models.Menu;

namespace EatQuickPizza.Application.Models.Order;

public class OrderInfo: IObservable<OrderInfo>
{
    private List<IObserver<OrderInfo>> _observers;
    
    private readonly int _orderId;
    public int OrderId => _orderId;

    private Bill _bill;

    public Bill Bill
    {
        get => _bill;
        set => _bill = value; 
    }
    public List<IMenuItem> MenuItems { get; } = new();

    private OrderStatus _status;
    public OrderStatus Status => _status;

    public OrderInfo(int orderId)
    {
        _orderId = orderId;
        _observers = new List<IObserver<OrderInfo>>();
        _status = OrderStatus.Idle;
    }
    
    

    public IDisposable Subscribe(IObserver<OrderInfo> observer)
    {
        _observers.Add(observer);
        return new Unsubscriber(_observers, observer);
    }

    private class Unsubscriber : IDisposable
    {
        private List<IObserver<OrderInfo>> _observers;
        private IObserver<OrderInfo> _observer;

        public Unsubscriber(List<IObserver<OrderInfo>> observers, IObserver<OrderInfo> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }

    public void UpdateStatus(OrderStatus status)
    {
        Console.WriteLine($"order of id {_orderId} has updated its status to {_status.ToString()}");
        _status = status;
        _observers.ForEach(observer =>
        {
            observer.OnNext(this);
        });
    }
}