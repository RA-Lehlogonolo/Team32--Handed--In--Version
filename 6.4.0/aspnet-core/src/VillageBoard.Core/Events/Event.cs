using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Event_Types;
using VillageBoard.Residences;
using VillageBoard.Statuses;

namespace VillageBoard.Events
{
    public class Event : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public byte Poster { get; set; }

        [Required]
        [MaxLength(150)]
        public string Location { get; set; }

        [Required]
        public DateTime Date { get; set; }

        //Child References

        public IEnumerable<Status> Statuses { get; set; }


        //Fk References

        [ForeignKey(nameof(Event_Type))]
        public int EventTypeId { get; set; }
        public Event_Type Event_Type { get; set; }

        [ForeignKey(nameof(Authorization.Users.User))]
        public long UserId { get; set; }
        public Authorization.Users.User User { get; set; }

        [ForeignKey(nameof(Residence))]
        public int ResidenceId { get; set; }
        public Residence Residence { get; set; }


    }
}
