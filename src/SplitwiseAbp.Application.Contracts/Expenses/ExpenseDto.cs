using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SplitwiseAbp.Expenses
{
   public class ExpenseDto : AuditedEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public Guid paiduser_id { get; set; }
        public decimal amount { get; set; }
        public decimal shareAmount { get; set; }

    }
}
