namespace CiroPizza.Models
{
    /// <summary>
    /// E' una classe di intesezione che facilita le relazioni molti a molti
    /// </summary>
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        //Foreign key
        public int ProductId { get; set; }
        //Foreign key
        public int OrderId { get; set; }
        //Navigation Property
        public Order Order { get; set; } = null!;
        //Navigation Property
        public Product Product { get; set; } = null!;
    }
}