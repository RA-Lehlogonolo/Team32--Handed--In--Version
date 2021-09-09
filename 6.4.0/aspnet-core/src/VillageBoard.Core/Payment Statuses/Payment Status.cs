using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Annoucements;
using VillageBoard.Payments;

namespace VillageBoard.Payment_Statuses
{
    public class Payment_Status : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //Child references
        public IEnumerable<Payment> Payments { get; set; }

    }
}
