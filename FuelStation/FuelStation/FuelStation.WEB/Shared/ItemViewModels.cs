using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FuelStation.Shared
{
    public class ItemViewModel
    {
        public Guid ID { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Code must be maximum 30 characters")]
        public string Code { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Description must be maximum 30 characters")]
        public string Description { get; set; }
        [Required]
        public ItemType ItemType { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Cost { get; set; }
    }

    public class ItemListViewModel
    {
        public List<ItemViewModel> ItemViewModels { get; set; } = new List<ItemViewModel>();
    }
}
