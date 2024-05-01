using BoutiqueEnLigne.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Service
{
    public class ProduitService
    {
        private readonly BoutiqueEnLigneContext dbContext;

        public ProduitService(BoutiqueEnLigneContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // CRUD methods
    }
}
