using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Suppliers;
using VillageBoard.Product_Types;
using VillageBoard.Sizes;
using Abp.Domain.Entities;
using VillageBoard.Annoucements;
using VillageBoard.Prices;

namespace VillageBoard.Products
{
    public class Product : Entity<int>
    {
        [Required]
        [MaxLength(50)] 
        public string Name { get; set; }

        [Required]
        [MaxLength(225)]
        public string Decription { get; set; }

        public byte Image { get; set; }


        [Required]
        public int Qty { get; set; }

        //Child References

        public IEnumerable<Price> Price { get; set; }



        //FK References

        [ForeignKey(nameof(Supplier))]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [ForeignKey(nameof(Size))]
        public int SizID { get; set; }
        public Size Size { get; set; }

        [ForeignKey(nameof(Product_Type))]
        public int ProductTypeId { get; set; }
        public Product_Type Product_Type { get; set; }


    }
}
