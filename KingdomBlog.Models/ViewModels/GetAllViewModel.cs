using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomBlog.Models.ViewModels
{
    public class GetAllViewModel
    {
        public  List<UserDetailsViewModel> AllUsers { get; } = new List<UserDetailsViewModel>();

        public List<EditorDetailsViewModel> AllEditors { get; } = new List<EditorDetailsViewModel>();
        
        public AdminDetailsViewModel AdminDetails { get; }

        public UserToDeleteReturnModel UserToDelete { get; set; }

    }
}
