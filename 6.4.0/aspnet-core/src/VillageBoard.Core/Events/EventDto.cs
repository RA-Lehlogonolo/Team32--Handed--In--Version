using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Events
{
  public  class EventDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Event))]

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
    }
}
