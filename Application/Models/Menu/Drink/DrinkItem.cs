namespace EatQuickPizza.Application.Models.Menu.Drink;

public class DrinkItem : IMenuItem
{
    private readonly int _drinkId;
    public int DrinkId => _drinkId;

    private readonly DrinkType _type;
    public DrinkType DrinkType => _type;

    public DrinkItem(int drinkId, DrinkType type)
    {
        _drinkId = drinkId;
        _type = type;
    }
}