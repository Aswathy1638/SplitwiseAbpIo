using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SplitwiseAbp.Groups
{
    public class CreateUpdateGroupDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
}
