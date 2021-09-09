using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Blocks;
using VillageBoard.Campuses;
using VillageBoard.Events;
using VillageBoard.Residence_Types;

namespace VillageBoard.Residences
{
    public class Residence : EntityDto<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(225)]
        public string Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string Gender { get; set; }

        //Child Reference
        public IEnumerable<Block> Blocks { get; set; }
        public IEnumerable<Event> Event { get; set; }


        //Fk Refercnces

        [ForeignKey(nameof(Residence_Type))]
        public int ResidenceTypeId { get; set; }
        public Residence_Type Residence_Type { get; set; }

        [ForeignKey(nameof(Campus))]
        public int CampusId { get; set; }
        public Campus Campus { get; set; }


       

    }
}
