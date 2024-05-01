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
    public class CategorieService
    {
        private readonly BoutiqueEnLigneContext dbContext;

        public CategorieService(BoutiqueEnLigneContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // CRUD methods

        // Create a new categorie
        public void AddCategorie(Categorie categorie)
        {
            dbContext.Categories.Add(categorie);
            dbContext.SaveChanges();
        }

        // Get all categories
        public List<Categorie> GetAllCategories()
        {
            return dbContext.Categories.ToList();
        }

        // Get a category by ID
        public Categorie GetCategorieById(int id)
        {
            return dbContext.Categories.FirstOrDefault(c => c.Id == id);
        }

        // Update a category
        public void UpdateCategorie(Categorie categorie)
        {
            dbContext.Entry(categorie).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        // Delete a category
        public void DeleteCategorie(int id)
        {
            var categorie = dbContext.Categories.Find(id);
            dbContext.Categories.Remove(categorie);
            dbContext.SaveChanges();
        }
    }
}

