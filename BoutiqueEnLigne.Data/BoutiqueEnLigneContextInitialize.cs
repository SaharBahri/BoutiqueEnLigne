using BoutiqueEnLigne.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Data
{
    public class BoutiqueEnLigneContextInitialize : CreateDatabaseIfNotExists<BoutiqueEnLigneContext>
    {
        protected override void Seed(BoutiqueEnLigneContext context)
        {
            context.Clients.Add(new Client { Login="hadil" , Password="1234" });
            context.SaveChanges();
        }
    }
}
