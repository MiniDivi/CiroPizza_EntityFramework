namespace CiroPizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }

        //Foreign key verso la tabella Customer, se non la mettiamo EF Core la crea automaticamente e si chiama "shadow property"
        public int CustomerId { get; set; }

        //è un altro tipo di "navigation property" che specifica un cliente per ordine
        public Customer Customer { get; set; } = null!;

        //altra navigation property
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}