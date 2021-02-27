using KingdomBlog.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KingdomBlog.Repository
{
    public interface IPostRepository
    {
        Task<bool> LikePost(ActivityViewModel viewModel);

        Task<bool> CommentOnPost(ActivityViewModel viewModel);

        Task<bool> ViewPost(ActivityViewModel viewModel);

        Task<bool> AddPost(PostViewModel viewModel);

        Task<bool> UpdatePost(PostViewModel viewModel);

        Task<bool> DeleteComment(ActivityViewModel viewModel);

        Task<bool> ApprovePosts(PostApprovalViewModel viewModel);

        Task<bool> AllPosts();

    }
}
