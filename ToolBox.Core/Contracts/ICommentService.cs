﻿using ToolBox.Core.Models.Comment;

namespace ToolBox.Core.Contracts
{
    public interface ICommentService
    {
        Task AddCommentAsync(CommentModel model);
        Task<CommentModel> GetCommentByIdAsync(int id);
        Task<int> EditPostAsync(CommentModel model);
        Task<CommentModel> DeleteCommentAsync(int id);
        Task<int> DeleteAsync (int id);
    }
}
