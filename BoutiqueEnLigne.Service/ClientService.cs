using BoutiqueEnLigne.Data;
using BoutiqueEnLigne.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Service
{
    public class ClientService
    {
        private readonly BoutiqueEnLigneContext dbContext;

        public ClientService(BoutiqueEnLigneContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Méthode pour ajouter un nouveau client
        public void AddClient(Client client)
        {
            dbContext.Clients.Add(client);
            dbContext.SaveChanges();
        }

        // Méthode pour récupérer tous les clients
        public List<Client> GetAllClients()
        {
            return dbContext.Clients.ToList();
        }

        // Méthode pour récupérer un client par son ID
        public Client GetClientById(int id)
        {
            return dbContext.Clients.FirstOrDefault(c => c.Id == id);
        }

        // Méthode pour mettre à jour un client existant
        public void UpdateClient(Client client)
        {
            dbContext.Entry(client).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        // Méthode pour supprimer un client
        public void DeleteClient(int id)
        {
            var client = dbContext.Clients.Find(id);
            dbContext.Clients.Remove(client);
            dbContext.SaveChanges();
        }

        // Méthode pour vérifier les informations de connexion
        public int? Authenticate(string login, string password)
        {
            // Recherchez le client dans la base de données avec le login donné
            var client = dbContext.Clients.FirstOrDefault(c => c.Login == login);

            // Vérifiez si le client existe et si le mot de passe correspond
            if (client != null && client.Password == password)
            {
                // Si les informations de connexion sont correctes, retournez l'ID du client
                return client.Id;
            }
            else
            {
                // Sinon, retournez null pour indiquer une authentification échouée
                return null;
            }
        }
    }
}

