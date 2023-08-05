using System.Collections.Generic;

class Client
{
    private List<ClientInfo> clients = new List<ClientInfo>();

    public void CreateClient(ClientInfo client)
    {
        if (!ValidateClient(client))
        {
            throw new ArgumentException("Invalid client information.");
        }

        clients.Add(client);
        Console.WriteLine("Client created and added successfully!");
    }

    public ClientInfo GetClientByName(string firstName, string lastName)
    {
        return clients.Find(client => client.FirstName == firstName && client.LastName == lastName);
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