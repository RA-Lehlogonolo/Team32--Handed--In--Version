using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Events;

namespace VillageBoard.Event_Types
{
   public class Event_Type : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Description { get; set; }

        //Child References

        public IEnumerable<Event> Event { get; set; }

    }
}
