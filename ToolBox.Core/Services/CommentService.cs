using Microsoft.EntityFrameworkCore;
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

        public async Task AddCommentAsync(CommentModel model)
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

        public async Task<CommentModel> GetCommentByIdAsync(int id)
        {
            return await repository.AllAsync<Comment>()
             .Where(c => c.Id == id)
             .Select(c => new CommentModel()
             {
                 Id = c.Id,
                 UserId = c.UserId,
                 DateTime = c.Time,
                 ProductId = c.ProductId,
                 ProductComment = c.ProductComment
             }).FirstAsync();
        }

        public async Task<int> EditPostAsync(CommentModel model)
        {
            var comment = repository.GetByIdAsync<Comment>(model.Id).Result;

            comment.ProductComment = model.ProductComment;
            await repository.SavaChangesAsync();
            return comment.Id;
        }

        public async Task<CommentModel> DeleteCommentAsync(int id)
        {
            return await repository.AllAsync<Comment>()
                .Where(c => c.Id == id)
                .Select(c => new CommentModel()
                {
                    Id = c.Id,
                    UserId = c.UserId,
                    DateTime = c.Time,
                    ProductId = c.ProductId,
                    ProductComment = c.ProductComment
                }).FirstAsync();
        }
        public async Task<int> DeleteAsync(int id)
        {
            var comment = await repository.GetByIdAsync<Comment>(id);

            await repository.RemoveAsync<Comment>(comment);
            await repository.SavaChangesAsync();

            return comment.ProductId;
        }
    }
}
