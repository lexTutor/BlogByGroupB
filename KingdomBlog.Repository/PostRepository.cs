using DataContext;
using KingdomBlog.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KingdomBlog.Repository
{
    public class PostRepository : IPostRepository
    {
        private DataBaseContext _dataBaseContext { get; }
        public PostRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public Task<bool> AddPost(PostViewModel viewModel)
        {
            //CHUKWUEMEKA
            throw new NotImplementedException();
        }

        public Task<bool> AllPosts()
        {
            //PETER
            throw new NotImplementedException();
        }

        public Task<bool> ApprovePosts(PostApprovalViewModel viewModel)
        {
            //CHIBUIKEM
            throw new NotImplementedException();
        }

        public Task<bool> CommentOnPost(ActivityViewModel viewModel)
        {
            //CHUKWUEMEKA
            throw new NotImplementedException();
        }

        public Task<bool> DeleteComment(ActivityViewModel viewModel)
        {
            //CHIBUIKEM
            throw new NotImplementedException();
        }

        public Task<bool> LikePost(ActivityViewModel viewModel)
        {
            //PETER
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePost(PostViewModel viewModel)
        {
            //PETER
            throw new NotImplementedException();
        }

        public Task<bool> ViewPost(ActivityViewModel viewModel)
        {
            //PETER
            throw new NotImplementedException();
        }
    }
}
