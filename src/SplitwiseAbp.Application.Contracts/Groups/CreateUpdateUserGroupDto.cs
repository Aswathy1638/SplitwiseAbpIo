using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SplitwiseAbp.Groups
{
    public class CreateUpdateUserGroupDto
    {

        [Required]

        public Guid UserId { get; set; }
    

        [Required]

        public Guid GroupId { get; set; }
    }
}
