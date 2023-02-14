namespace ddd_pratica.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }  

        public bool IsActive { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
    }
}
