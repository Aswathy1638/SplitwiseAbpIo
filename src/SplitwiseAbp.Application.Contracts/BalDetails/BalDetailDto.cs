using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;

namespace SplitwiseAbp.BalDetails
{
    public class BalDetailDto : AuditedEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid userId { get; set; }
        public Guid debtUserId { get; set; }
        public decimal balance_amount { get; set; }

   
    }
}
