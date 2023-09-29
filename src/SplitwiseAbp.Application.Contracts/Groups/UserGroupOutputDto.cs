using System;
using System.Collections.Generic;
using System.Text;

namespace SplitwiseAbp.Groups
{
   public class UserGroupOutputDto
    {
        public string UserName { get; set; }
        public string GroupName { get; set; }
        public Guid UserId { get; set; }
        public Guid GroupId { get; set; }
    }
}
