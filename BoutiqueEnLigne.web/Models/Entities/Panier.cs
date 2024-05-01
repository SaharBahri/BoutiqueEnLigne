using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.web.Models.Entities
{
    public class Panier
    {
        public int Id { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<ProduitPanier> ProduitsPanier { get; set; }

    }
}
