using SplitwiseAbp.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SplitwiseAbp.Expenses
{
    public class Expense : AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public Guid paiduser_id { get; set; }
        public decimal amount { get; set; }
        public decimal shareAmount { get; set; }

        public Group Group { get; set; }
        public ICollection<IdentityUser> Participants { get; set; }
    
    }
}
