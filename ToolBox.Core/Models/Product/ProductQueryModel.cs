namespace ToolBox.Core.Models.Product
{
    public class ProductQueryModel
    {
        public int Id { get; set; } 
        public string ProductName { get; set; } = string.Empty; 
        public string SKU { get; set; } = string.Empty; 
        public string? ProductDescription { get; set; }
        public string? Size { get; set; }
        public string? Characteristic { get; set; }
        public string ImageBase64 { get; set; } = string.Empty; 
        public decimal ProductPrice { get; set; } 
        public int Quantity { get; set; } 
        public decimal Weight { get; set; } 
        public bool IsInStock { get; set; } 
        public bool IsPromo { get; set; } 
        public decimal PromoPrice { get; set; } 
    }
}
