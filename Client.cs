using System.Collections.Generic;

public interface IClientService
{
    void CreateClient(ClientInfo client);
    ClientInfo GetClientByName(string firstName, string lastName);
    void UpdateClientName(ClientInfo client, string newFirstName, string newLastName);
    void RemoveClient(ClientInfo client);
}

public abstract class Client : IClientService
{
    private List<ClientInfo> clients = new List<ClientInfo>();

    public virtual void CreateClient(ClientInfo client)
    {
        if (!ValidateClient(client))
        {
            throw new ArgumentException("Invalid client information.");
        }

        clients.Add(client);
        Console.WriteLine("Client created and added successfully!");
    }

    public virtual ClientInfo GetClientByName(string firstName, string lastName)
    {
        return clients.Find(client => client.FirstName == firstName && client.LastName == lastName);
    }

    public virtual void UpdateClientName(ClientInfo client, string newFirstName, string newLastName)
    {
        if (client != null)
        {
            client = client with { FirstName = newFirstName, LastName = newLastName };
            Console.WriteLine("Client name updated successfully!");
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
    }

    public virtual void RemoveClient(ClientInfo client)
    {
        if (client != null)
        {
            clients.Remove(client);
            Console.WriteLine("Client removed successfully!");
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
    }


    private bool ValidateClient(ClientInfo client)
    {
        return !string.IsNullOrWhiteSpace(client.FirstName) &&
               !string.IsNullOrWhiteSpace(client.LastName) &&
               !string.IsNullOrWhiteSpace(client.Phone) &&
               !string.IsNullOrWhiteSpace(client.Email) &&
               !string.IsNullOrWhiteSpace(client.Password);
        
    }
}