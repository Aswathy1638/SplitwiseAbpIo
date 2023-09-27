using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SplitwiseAbp.Groups
{
   public class UserGroup : AuditedAggregateRoot<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
        public Guid UserId { get; set; }  
        
        public IdentityUser User { get; set; }
}
}
