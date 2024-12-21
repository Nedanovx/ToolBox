using ToolBox.Core.Models.Comment;
namespace ToolBox.Core.Models.Details
{
	public class DetailsQueryModel
	{
		public int Id { get; set; }

		public string ProductName { get; set; } = string.Empty;

		public string SKU { get; set; } = string.Empty;

		public string? ProductDescription { get; set; }

		public string ImageBase64 { get; set; } = string.Empty;

		public decimal ProductPrice { get; set; }

		public int Quantity { get; set; }

		public bool IsInStock { get; set; }

		public decimal PromoPrice {  get; set; }

		public IEnumerable<CommentQueryModel> AllComments { get; set; } = new HashSet<CommentQueryModel>();
	}
}
