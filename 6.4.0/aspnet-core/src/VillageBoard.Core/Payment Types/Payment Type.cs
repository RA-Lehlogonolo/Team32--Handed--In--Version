using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Payments;
using VillageBoard.Products;

namespace VillageBoard.Payment_Types
{
    public class Payment_Type : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //Child References

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Payment> Payments { get; set; }


    }
}
