using BoutiqueEnLigne.web.Models;
using BoutiqueEnLigne.web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;


namespace BoutiqueEnLigne.web.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public ClientController(ApplicationDbContext dbContext)
        {


        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddClientViewModel viewModel)
        {
            var client = new Client
            {
                Id = viewModel.Id,
                Nom = viewModel.Nom,
                Adresse = viewModel.Adresse,
                Email = viewModel.Email,
                Login = viewModel.Login,
                Password = viewModel.Password

            };
            await dbContext.AddAsync(client);
            await dbContext.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return View(await dbContext.GetClient().ToListAsync());
        }

        [HttpGet]
        public async  Task<IActionResult> Edit(Guid id)
        {
           var client =  await dbContext.GetClient().FindAsync(id);
            return View(client);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Client viewModel)
        {
            var client = await dbContext.GetClient().AsNoTracking().FirstOrDefaultAsync(x => x.Id == viewModel.Id);
            if (client is not null) { 
                client.Nom = viewModel.Nom;
                client.Adresse = viewModel.Adresse; 
                client.Email = viewModel.Email;
                client.Login = viewModel.Login;
                client.Password = viewModel.Password;

                await dbContext.SaveChangesAsync();
                    
            }

            return RedirectToAction("List", "Clients");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Client viewModel)
        {
            var client = await dbContext.GetClient().FindAsync(viewModel.Id);
            if (client is not null)
            {
                dbContext.GetClient().Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Clients");
        }
    }
}
