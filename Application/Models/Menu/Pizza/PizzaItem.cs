namespace EatQuickPizza.Application.Models.Menu.Pizza;

public class PizzaItem : IMenuItem
{
    private readonly int _pizzaId;
    public int PizzaId => _pizzaId;

    private readonly PizzaSize _size;
    private readonly PizzaType _type;

    public PizzaSize PizzaSize => _size;
    public PizzaType PizzaType => _type;

    public PizzaItem(int pizzaId, PizzaSize size, PizzaType type)
    {
        _pizzaId = pizzaId;
        _size = size;
        _type = type;
    }
}