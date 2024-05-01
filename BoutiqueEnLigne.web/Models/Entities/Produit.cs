using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.web.Models.Entities
{
    public class Produit
    {
        public int Id { get; set; }    
        public string Nom { get; set; }
        public float Prix { get; set; }

        public string Description { get; set; }
        public int Stock { get; set; }
        public virtual Categorie Categorie { get; set; }
        
    }
}
