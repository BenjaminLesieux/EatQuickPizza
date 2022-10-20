using EatQuickPizza.Application.Models.Order;

namespace EatQuickPizza.Application.Dao;

public class Kitchen
{
    private List<Bill> _bills;
    private List<OrderInfo> _orderInfos;

    private KitchenStaff _kitchenStaff;
    public Kitchen()
    {
        _bills = new List<Bill>();
        _orderInfos = new List<OrderInfo>();
    }

    public void SetKitchenStaff(KitchenStaff kitchenStaff)
    {
        _kitchenStaff = kitchenStaff;
    }

    public List<OrderInfo> GetOrders()
    {
        return _orderInfos;
    }

    public void RegisterOrder(OrderInfo orderInfo)
    {
        if (_orderInfos.Contains(orderInfo)) return;

        Console.WriteLine($"[Kitchen] Register order of id {orderInfo.OrderId}");
        _orderInfos.Add(orderInfo);
    }

    public void UpdateOrder(OrderInfo orderInfo, OrderStatus orderStatus)
    {
        orderInfo.UpdateStatus(orderStatus);
        Console.WriteLine($"[Kitchen] Update order of id {orderInfo.OrderId}");
    }

    public void SendOrderToKitchen(OrderInfo orderInfo)
    {
        if (_orderInfos.Contains(orderInfo)) return;
        
        RegisterOrder(orderInfo);
        Thread.Sleep(1000 * orderInfo.MenuItems.Count);
        Console.WriteLine($"[Kitchen] Received Order {orderInfo.OrderId} composed of {orderInfo.MenuItems.ToString()}");
    }

    public List<Bill> GetBills()
    {
        return _bills;
    }

    public void RegisterBill(OrderInfo orderInfo, Bill bill)
    {
        if (_bills.Contains(bill)) return;

        Console.WriteLine($"[Kitchen] Creating bill for order of id {orderInfo.OrderId}");
        _bills.Add(bill);
        orderInfo.Bill = bill;
    }

    public void UpdateBill(Bill bill, BillStatus billStatus)
    {
    }
}