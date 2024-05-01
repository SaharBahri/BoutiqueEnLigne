using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Domain.Entities
{
    public class ProduitPanier
    {
        public int Id { get; set; }
        public int ProduitId { get; set; }
        public int PanierId { get; set; }
        public int Quantite { get; set; }
        public virtual Produit Produit { get; set; }
        public virtual Panier Panier { get; set; }
    }
}
