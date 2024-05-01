using Microsoft.EntityFrameworkCore;


using BoutiqueEnLigne.web.Models.Entities;




namespace BoutiqueEnLigne.web;
//public class ApplicationDbContext : BoutiqueEnLigneContext{ }  

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    private DbSet<Client> client;

    public DbSet<Client> GetClient()
    {
        return client;
    }

    public void SetClient(DbSet<Client> value)
    {
        client = value;
    }

    public object Client { get;  set; }
}
    