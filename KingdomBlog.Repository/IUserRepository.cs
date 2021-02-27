using KingdomBlog.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KingdomBlog.Repository
{
    public interface IUserRepository
    {
        Task<bool> AddUser(UserRecieverView viewModel);

        Task<bool> ToLogin(ToLoginViewModel viewModel);

        Task<bool> DeleteUser(UserToDeleteReturnModel returnModel);

        Task<bool> GetAllUsers();

        Task<bool> UserToUpgradeToEditor(UserDetailsViewModel viewModel);

        Task<bool> EditorToUpgradeToProEditor(UserDetailsViewModel viewModel);

        Task<bool> PromoteMemberToEditor(UserDetailsViewModel viewModel);

        Task<bool> PromoteEditorToAdmin(UserDetailsViewModel viewModel);

    }
}
