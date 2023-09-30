using System;
using System.Collections.Generic;
using System.Text;

namespace SplitwiseAbp.Transactions
{
   public class CreateUpdateTransactionDto
    {
        public Guid groupId { get; set; }
        public Guid payerUserId { get; set; }
        public Guid paidUserId { get; set; }
        public Guid expenseId { get; set; }
        public decimal transaction_Amount { get; set; }
    }
}
