using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SplitwiseAbp.Participants
{
   public class ParticipantDto: AuditedEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public decimal amount { get; set; }
    }
}
