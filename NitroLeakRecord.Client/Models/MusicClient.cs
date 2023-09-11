using System.Net;
using NitroLeakRecord.Client.Models;

namespace NitroLeakRecord.Client.Models;
public class MusicClient
{
    private static readonly List<Client> clients = new()
    {
        new Client(){
        Id = 1,
        FirstName = "Corentin",
        LastName = "JEANNOT",
        Email = "corentin.jeannot2a@gmail.com",
        Gender = "Homme",
        Wallet = 0.00M,
        DateOfBirth = new DateTime(1999, 11, 21)
        },
        new Client(){
        Id = 2,
        FirstName = "Tom",
        LastName = "JEANNOT",
        Email = "tom.jeannot2a@gmail.com",
        Gender = "Homme",
        Wallet = 0.00M,
        DateOfBirth = new DateTime(2002, 12, 17)
        },
        new Client(){
        Id = 3,
        FirstName = "Nathan",
        LastName = "JEANNOT",
        Email = "nathan.jeannot2a@gmail.com",
        Gender = "Homme",
        Wallet = 0.00M,
        DateOfBirth = new DateTime(2005, 07, 15)
        }
    };

    public static Client[] GetClients()
    {
        return clients.ToArray();
    }

    public static void addClient(Client client)
    {
        client.Id = clients.Max(client => client.Id) + 1;
        clients.Add(client);
    }

    public static Client GetClientById(int id)
    {
        return clients.Find(client => client.Id == id) ?? throw new Exception("Client introuvable !");
    }

    public static void UpdateClient(Client updatedClient)
    {
        Client existingClient = GetClientById(updatedClient.Id);
        existingClient.FirstName = updatedClient.FirstName;
        existingClient.LastName = updatedClient.LastName;
        existingClient.Email = updatedClient.Email;
        existingClient.Gender = updatedClient.Gender;
        existingClient.Wallet = updatedClient.Wallet;
        existingClient.DateOfBirth = updatedClient.DateOfBirth;
    }

    public static void DeleteClient(int id)
    {
        Client client = GetClientById(id);
        clients.Remove(client);
    }
}
