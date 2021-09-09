using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Residences;
using VillageBoard.Rooms;

namespace VillageBoard.Blocks
{
    public class Block : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(225)]
        public string Description { get; set; }

        //Child References

        public IEnumerable<Room> Rooms { get; set; }


        //FK Reference

        [ForeignKey(nameof(Residence))]
        public int ResidenceId { get; set; }
        public Residence Residence { get; set; }


    }
}
