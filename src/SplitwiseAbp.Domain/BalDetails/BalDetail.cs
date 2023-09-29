using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SplitwiseAbp.BalDetails
{
    public class BalDetail :AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public Guid userId { get; set; }
        public Guid debtUserId { get; set; }
        public decimal balance_amount { get; set; }

        public IdentityUser user { get; set; }

    }
}
