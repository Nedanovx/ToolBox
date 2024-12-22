using ToolBox.Core.Models.Comment;

namespace ToolBox.Core.Contracts
{
    public interface ICommentService
    {
        Task AddCommentAsync(AddCommentModel model);
    }
}
