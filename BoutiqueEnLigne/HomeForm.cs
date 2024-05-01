using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoutiqueEnLigne.Console
{
    public partial class HomeForm : Form
    {

        private int clientId;

        // Ajoutez une propriété publique pour permettre l'accès à l'ID du client depuis d'autres classes
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        public HomeForm(int clientId)
        {
            InitializeComponent();

            // Initialisez la propriété ClientId avec la valeur fournie en paramètre
            this.ClientId = clientId;
            label1.Text = "client id : " + clientId.ToString();
        }
    }
}
