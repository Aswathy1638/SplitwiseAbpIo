using SplitwiseAbp.Expenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SplitwiseAbp.Transactions
{
   public class Transaction : AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public Guid groupId { get; set; }
        public Guid payerUserId { get; set; }
        public Guid paidUserId { get; set; }
        public Guid expenseId { get; set; }
        public decimal transaction_Amount { get; set; }
        public DateTime transaction_Date { get; set; }
        public Expense Expense { get; set; }
        [JsonIgnore]
        public ICollection<IdentityUser> User { get; set; }
    }
}
