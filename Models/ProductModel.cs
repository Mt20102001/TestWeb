namespace TestWeb.Models
{
    public class ProductModel
    {
        public int id { get; set; }
        public string Name { set; get; }
        public bool Available { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
    }
}
