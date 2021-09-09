using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Item_Types;

namespace VillageBoard.Items
{
    public class Item : Entity<int>
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        //Fk References

        [ForeignKey(nameof(Item_Type))]
        public int ItemTypeId { get; set; }
        public Item_Type Item_Type { get; set; }


    }
}
