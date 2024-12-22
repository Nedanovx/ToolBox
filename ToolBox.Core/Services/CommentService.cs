using ToolBox.Core.Contracts;
using ToolBox.Core.Models.Comment;
using ToolBox.Infrastructure.Common;
using ToolBox.Infrastructure.Models;

namespace ToolBox.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository repository;
        public CommentService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddCommentAsync(AddCommentModel model)
        {
            await repository.AddAsync(new Comment()
            {
                ProductComment = model.ProductComment,
                ProductId = model.ProductId,
                Time = model.DateTime,
                UserId = model.UserId,
            });

            await repository.SavaChangesAsync();
        }
    }
}
