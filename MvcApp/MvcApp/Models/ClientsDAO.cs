using MvcNov17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    static class ClientsDAO
    {
        static List<Client> clients;

        static ClientsDAO()
        {
            clients = new List<Client>
            {
                new Client(nom: "AAA", prenom: "aaa", id: "A", DateNaissance : new DateTime(2000,12,12)),
                new Client(nom: "BBB", prenom: "bbb", id: "B", DateNaissance : new DateTime(2001,10,12)),
                new Client(nom: "EEE", prenom: "eee", id: "E", DateNaissance : new DateTime(2004,9,12)),
                new Client(nom: "CCC", prenom: "ccc", id: "C", DateNaissance : new DateTime(2002,8,12)),
                new Client(nom: "FFF", prenom: "fff", id: "F", DateNaissance : new DateTime(2005,7,12))
            };
        }

        public static Client GetClientById(string id)
        {
            return clients.Find(c => c.Id == id);
        }

        public static List<Client> GetAllClients()
        {
            return clients;
        }
        public static void AddClient(Client client)
        {
            clients.Add(client);
        }
        public static Client RemoveClient(String id)
        {
            if (id != null)
            {
                Client client = clients.Find(c => c.Id == id);
                if (client != null)
                {
                    if (clients.Remove(client))
                        return client;
                }
            }
            return null;
        }
        public static bool UpdateOrAddClient(Client client)
        {
            if (client != null)
            {
                Client cli = clients.Find(c => c.Id == client.Id);
                if (cli != null)
                {
                    cli.Nom = client.Nom;
                    cli.Prenom = client.Prenom;
                    cli.DateNaissance = client.DateNaissance;
                    return true;
                }
                else
                {
                    clients.Add(client);
                    return true;
                }
            }
            return false;
        }

    }
}