using CiroPizza.Data;
using CiroPizza.Models;

namespace CiroPizza
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creo una nuova istanza di CIroPizza
            //using si mette per assicurarsi che l'istanza venga eliminata dopo averla utilizzata
            using CiroPizzaContext context = new CiroPizzaContext();

            //#################################################################################################################################
            //Aggiungo due prodotti al database
            //#################################################################################################################################

            //Product margherita = new Product()
            //{
            //    Name = "Margherita",
            //    Price = 6.00M
            //};
            //context.Products.Add(margherita);

            //Product wurstel = new Product()
            //{
            //    Name = "Wurstel",
            //    Price = 7.00M
            //};
            //context.Add(wurstel);

            //context.SaveChanges();

            //#################################################################################################################################
            //Modifico un prodotto presente nel database
            //#################################################################################################################################
            
            //significa che se trovo il prodotto bene, lo prendo, altrimenti restituisce il valore di default che è null
            var margherita = context.Products
                                .Where(p => p.Name == "Margherita")
                                .FirstOrDefault();

            //controllo se l'oggetto recuperato è un prodotto
            if(margherita is Product)
            {
                margherita.Price = 7.50M;
            }

            //salvo le modifiche
            context.SaveChanges();

            //#################################################################################################################################
            //Rimuovo un prodotto dal database (uso l'oggetto "margerita" recuperato in precedenza)
            //#################################################################################################################################
            if(margherita is Product)
            {
                context.Remove(margherita);
            }
            context.SaveChanges();

            //#################################################################################################################################
            //Leggo i prodotti dal database (solo quelli che costano più di 5€ e li ordino per nome)
            //#################################################################################################################################
            var products = context.Products
                            .Where(p => p.Price > 5.00M)
                            .OrderBy(p => p.Name);

            //Cio che è stato scritto sopra può anche essere scritto così:
            /*
             * var products = from product in context.Products
             *                where product.Price > 10.00M
             *                orderby product.Name
             *                select product;
             */

            foreach(Product p in products)
            {
                Console.WriteLine($"Id: {p.Id}");
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Price: {p.Price}");
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}