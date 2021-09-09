using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VillageBoard.Collection_Reminders
{
    public class CollectionReminderDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Collection_Reminder))]

        [Required]
        [MaxLength(500)]
        public string Decription { get; set; }

        


    }
}
