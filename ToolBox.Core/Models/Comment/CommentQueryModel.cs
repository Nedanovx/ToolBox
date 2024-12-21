using System.ComponentModel.DataAnnotations;

namespace ToolBox.Core.Models.Comment
{
	public class CommentQueryModel
	{
		public int Id { get; set; }

		public string ProductComment { get; set; } = string.Empty;

		public DateTime DateTime { get; set; }

		public string FirstName { get; set; } = string.Empty;

		public string LastName { get; set; } = string.Empty;

		public int ProductId { get; set; }

		public string UserId { get; set; } = string.Empty;
	}
}
