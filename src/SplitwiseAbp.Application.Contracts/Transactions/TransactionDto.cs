using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SplitwiseAbp.Transactions
{
   public class TransactionDto : AuditedEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid groupId { get; set; }
        public Guid payerUserId { get; set; }
        public Guid paidUserId { get; set; }
        public Guid expenseId { get; set; }
        public decimal transaction_Amount { get; set; }
        public DateTime transaction_Date { get; set; }
    }
}
