using EatQuickPizza.Application.Models.Persons;

namespace EatQuickPizza.Application.Dao;

public class KitchenStaff
{

    private List<Client> _clients;
    private List<Clerk> _clerks;
    private List<Cook> _cooks;
    private List<DeliveryMan> _deliveryMen;

    public KitchenStaff(List<Client> clients, List<Clerk> clerks, List<Cook> cooks, List<DeliveryMan> deliveryMen)
    {
        _clients = clients;
        _clerks = clerks;
        _cooks = cooks;
        _deliveryMen = deliveryMen;
    }

    public List<Client> Clients
    {
        get => _clients;
        set => _clients = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Clerk> Clerks
    {
        get => _clerks;
        set => _clerks = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Cook> Cooks
    {
        get => _cooks;
        set => _cooks = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Client> GetAllClientByAlphabeticalOrder()
    {
        _clients.Sort();
        return _clients;
    }

    public List<Client> GetClientsByCity(string city)
    {
        return _clients.FindAll(client => client.Address == city || client.Address.Contains(city));
    }

    public void AddClient(Client client)
    {
        if (_clients.Contains(client))
        {
            Console.WriteLine("Cannot add client " + client + " : already in database");
            return;
        }
        
        _clients.Add(client);
    }

    public Client? GetClient(int clientId)
    {
        return _clients.Find(client => client.Id == clientId);
    }

    public Clerk? GetClerk(int clerkID)
    {
        return _clerks.Find(clerk => clerk.Id == clerkID);
    }

    public Cook? GetCook(int cookID)
    {
        return _cooks.Find(cook => cook.Id == cookID);
    }

    public DeliveryMan? GetDeliveryMan(int deliveryManID)
    {
        return _deliveryMen.Find(deliveryMan => deliveryMan.Id == deliveryManID);
    }
}