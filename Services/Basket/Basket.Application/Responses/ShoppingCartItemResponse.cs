namespace Basket.Application.Responses
{
    public class ShoppingCartItemResponse
    {
        public int Quantity { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
        public string ProducttId { get; set; }
        public string ProducttName { get; set; }
    }
}
