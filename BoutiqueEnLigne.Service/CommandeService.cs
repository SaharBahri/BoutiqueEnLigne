using BoutiqueEnLigne.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Service
{
    public class CommandeService
    {
        private readonly BoutiqueEnLigneContext dbContext;

        public CommandeService(BoutiqueEnLigneContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // CRUD methods
    }
}
