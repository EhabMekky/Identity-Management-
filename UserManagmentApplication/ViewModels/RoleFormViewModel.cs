using System.ComponentModel.DataAnnotations;

namespace UserManagementApplication.ViewModels
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string RoleId { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
    }
}
