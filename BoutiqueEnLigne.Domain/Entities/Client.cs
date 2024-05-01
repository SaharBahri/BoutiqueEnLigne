using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueEnLigne.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }    
        public string Adresse { get; set; }
        public string Email { get; set;}
        public string Login { get; set;}
        public string Password { get; set;}
        public virtual ICollection<Commande> Commandes { get; set; }

        public virtual Panier Panier { get; set; }
    }
}
