namespace CiroPizza.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        //è una "navigation property" indica che ci possono essere 0 o più ordini. Serve per creare una relazione uno a molti.
        public ICollection<Order> Orders { get; set; } = null!;
    }
}
