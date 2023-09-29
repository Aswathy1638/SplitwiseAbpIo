using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SplitwiseAbp.FriendShips
{
    public class Friends : AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public Guid FriendId { get; set; }
        public Guid UserId { get; set; }
        public string FriendName { get; set; }
        public string UserName { get; set; }
    }
}
