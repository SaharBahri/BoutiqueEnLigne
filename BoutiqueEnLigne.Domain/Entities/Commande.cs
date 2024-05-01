using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Domain.Entities
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<ProduitPanier> ProduitsPanier { get; set; }
    }
}
