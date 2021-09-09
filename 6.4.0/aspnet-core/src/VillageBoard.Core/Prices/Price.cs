using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Products;

namespace VillageBoard.Prices
{
    public class Price : Entity<int>
    {
        [Required]
        public decimal ProductPrice { get; set; }


        [Required]
        public DateTime Date { get; set; }

        //Fk References

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
