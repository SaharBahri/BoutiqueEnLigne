using BoutiqueEnLigne.Console;
using BoutiqueEnLigne.Data;
using BoutiqueEnLigne.Domain.Entities;
using BoutiqueEnLigne.Service;

namespace BoutiqueEnLigne
{
    public partial class LoginForm : Form
    {

        private readonly ClientService clientService;
        public LoginForm()
        {
            InitializeComponent();
            // Initialize ClientService with required dependencies
            var dbContext = new BoutiqueEnLigneContext(); // Create your DbContext instance
            clientService = new ClientService(dbContext); // Pass DbContext to ClientService constructor
        }

        private void button1_Click(object sender, EventArgs e)
        { // Récupérer les informations de connexion saisies par l'utilisateur
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            // Vérifier si les informations de connexion sont valides
            if (IsLoginValid(login, password) > -1)
            {

                // Obtenir l'ID du client à partir de votre système (par exemple, en le recherchant dans la base de données)
                int clientId = IsLoginValid(login, password);

                // Si les informations sont valides, rediriger vers une nouvelle forme (par exemple, HomeForm)
                HomeForm homeForm = new HomeForm(clientId);
                this.Hide(); // Cacher la forme de connexion
                homeForm.ShowDialog(); // Afficher la nouvelle forme
                this.Close(); // Fermer la forme de connexion après la connexion réussie
            }
            else
            {
                // Si les informations de connexion ne sont pas valides, afficher un message d'erreur
                MessageBox.Show("Identifiant ou mot de passe incorrect !");
            }
        }

        private int IsLoginValid(string login, string password)
        {
            int? clientId = clientService.Authenticate(login, password);

            if (clientId.HasValue && clientId > -1)
            {
                return clientId.Value; // Use Value property to access the int value of nullable int
            }
            else
            {
                return -1;
            }
        }

    }
}
