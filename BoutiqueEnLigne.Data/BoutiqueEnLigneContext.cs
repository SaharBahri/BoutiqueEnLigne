using BoutiqueEnLigne.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Data
{
    public class BoutiqueEnLigneContext : DbContext
    {
        public BoutiqueEnLigneContext() : base(GetConnectionString()) {
            // Activer l'initialiseur de la base de données
            Database.SetInitializer<BoutiqueEnLigneContext>(new BoutiqueEnLigneContextInitialize());
        }

        private static string GetConnectionString()
        {
            //return ConfigurationManager.ConnectionStrings["MyFinanceContext"].ConnectionString;
            return "Data Source=DESKTOP-8IE53N2;Persist Security Info=True;Database=BoutiqueEnLigneDB;User ID=sa;Password=pass;Encrypt=False;";
        }

        public DbSet<Produit> Produits { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Panier> Panier { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<ProduitPanier> produitPaniers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasOptional(c => c.Panier) // Client can have optional Panier
                .WithRequired(p => p.Client); // Panier is required for a Client
        }
    }
}
