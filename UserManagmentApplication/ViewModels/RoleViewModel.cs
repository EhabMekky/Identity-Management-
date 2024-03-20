using Microsoft.AspNetCore.Components.Web;

namespace UserManagementApplication.ViewModels
{
    public class RoleViewModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsSelected { get; set; }
    }
}
