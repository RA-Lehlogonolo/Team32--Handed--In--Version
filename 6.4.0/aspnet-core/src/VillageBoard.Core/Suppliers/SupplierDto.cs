using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Suppliers
{
    public class SupplierDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Supplier))]

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(13)]
        public string Contact_Number { get; set; }

        [Required]
        [MaxLength(250)]
        public string Physical_Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
