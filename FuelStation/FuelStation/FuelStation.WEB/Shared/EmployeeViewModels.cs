using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuelStation.Shared
{
    public class EmployeeViewModel
    {
        public Guid ID { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Name must be maximum 30 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Surname must be maximum 30 characters")]
        public string Surname { get; set; }
        [Required]
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        [Required]
        public decimal SallaryPerMonth { get; set; }
        [Required]
        public EmployeeType EmployeeType { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Username must be maximum 30 characters")]
        public string Username { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Password must be maximum 30 characters")]
        public string Password { get; set; }
    }

    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> EmployeeViewModels { get; set; } = new List<EmployeeViewModel>();
    }
}
