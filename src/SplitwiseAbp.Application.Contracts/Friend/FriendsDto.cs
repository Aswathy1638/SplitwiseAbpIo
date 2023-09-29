using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SplitwiseAbp.Friend
{
public class FriendsDto: AuditedEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid FriendId { get; set; }
        public Guid UserId { get; set; }
        public string FriendName { get; set; }
        public string UserName { get; set; }

    }
}
