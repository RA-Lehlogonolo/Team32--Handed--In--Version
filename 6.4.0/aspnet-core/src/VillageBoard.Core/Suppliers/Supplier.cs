using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Products;

namespace VillageBoard.Suppliers
{
    public class Supplier : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(13)]
        public string Contact_Number { get; set; }

        [Required]
        [MaxLength(250)]
        public string Physical_Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        //Child References

        public IEnumerable<Product> Products { get; set; }
    }
}
