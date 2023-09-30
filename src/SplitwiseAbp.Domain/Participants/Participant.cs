using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SplitwiseAbp.Participants
{
   public class Participant:AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public  Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public decimal amount { get; set; }
    }
}
