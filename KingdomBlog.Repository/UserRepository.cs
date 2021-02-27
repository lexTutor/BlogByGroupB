using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataContext;
using KingdomBlog.Models.ViewModels;

namespace KingdomBlog.Repository
{
    public class UserRepository : IUserRepository
    {
       private DataBaseContext _dataBaseContext { get; }
        public UserRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public Task<bool> AddUser(UserRecieverView viewModel)
        {
            //Chukwuemeka
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(UserToDeleteReturnModel returnModel)
        {
            //CHUKWUEMEKA
            throw new NotImplementedException();
        }

        public Task<bool> EditorToUpgradeToProEditor(UserDetailsViewModel viewModel)
        {
            //PETER
            throw new NotImplementedException();
        }

        public Task<bool> GetAllUsers()
        {
            //CHIBUIKEM
            throw new NotImplementedException();
        }

        public Task<bool> PromoteEditorToAdmin(UserDetailsViewModel viewModel)
        {
            //CHIBUIKEM
            throw new NotImplementedException();
        }

        public Task<bool> PromoteMemberToEditor(UserDetailsViewModel viewModel)
        {
            //CHIBUIKEM
            throw new NotImplementedException();
        }

        public Task<bool> ToLogin(ToLoginViewModel viewModel)
        {
            //CHIBUIKEM
            throw new NotImplementedException();
        }

        public Task<bool> UserToUpgradeToEditor(UserDetailsViewModel viewModel)
        {
            //CHUKWUEMEKA
            throw new NotImplementedException();
        }
    }
}
