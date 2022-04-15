using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Shared
{
    public class CustomerViewModel
    {
        public Guid ID { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Name must be maximum 30 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Surname must be maximum 30 characters")]
        public string Surname { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Card Number must be maximum 30 characters")]
        [RegularExpression(@"^A.*", ErrorMessage = "Card Number must begin with the letter 'A'")]
        public string CardNumber { get; set; }
    }
    
    public class CustomerListViewModel
    {
        public List<CustomerViewModel> CustomerViewModels { get; set; } = new List<CustomerViewModel>();
    }
}
