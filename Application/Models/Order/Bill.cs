namespace EatQuickPizza.Application.Models.Order;

public class Bill
{
    private readonly int _billId;
    public int BillId => _billId;

    private readonly BillStatus _status;
    public BillStatus BillStatus => _status;

    public Bill(int billId, BillStatus status)
    {
        _billId = billId;
        _status = status;
    }
}