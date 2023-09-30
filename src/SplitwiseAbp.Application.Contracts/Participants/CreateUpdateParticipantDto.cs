using System;
using System.Collections.Generic;
using System.Text;

namespace SplitwiseAbp.Participants
{
    public class CreateUpdateParticipantDto
    {
       
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public decimal amount { get; set; }
    }
}
