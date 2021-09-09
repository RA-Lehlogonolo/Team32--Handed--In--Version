using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Disciplinary_Hearings;

namespace VillageBoard.Years
{
    public class Year : Entity<int>
    {
        [Required]
        public DateTime Date { get; set; }

        //Child References

        public IEnumerable<Disciplinary_Hearing> Disciplinary_Hearing { get; set; }


    }
}
