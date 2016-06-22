using Hackney.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Hackney.Core.ViewModels
{
    public class SelectRoleEditorViewModel
    {
        public SelectRoleEditorViewModel() { }
        public SelectRoleEditorViewModel(ApplicationRole role)
        {
            this.RoleName = role.Name;
            this.Description = role.Description;
        }

        public bool Selected { get; set; }

        [Required]
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}