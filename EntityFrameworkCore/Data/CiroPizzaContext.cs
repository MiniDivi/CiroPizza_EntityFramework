using CiroPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace CiroPizza.Data
{
    /// <summary>
    /// Implementa DbContext, che è rappresentabile come una sessione con il database
    /// </summary>
    public class CiroPizzaContext : DbContext
    {
        //Abbiamo 4 proprietà "DbSet", ogniuna di queste proprietà andrà a comporre la specifica tabella del database.
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        //Serve per includere delle informazioni di configurazione
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //questo non è il modo corretto per scrivere una stringa di connessione
            //per conoscere il modo corretto: https://aka.ms/ef-core-connection-strings
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=CiroPizza-1;Integrated Security=True;");  
        }
    }
}
