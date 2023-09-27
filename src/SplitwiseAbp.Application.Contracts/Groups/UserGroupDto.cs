using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SplitwiseAbp.Groups
{
   public class UserGroupDto: AuditedEntityDto<Guid>
    {
        public Guid UserId { get; set; }
        public Guid GroupId { get; set; }
    }
}
