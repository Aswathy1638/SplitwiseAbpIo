using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SplitwiseAbp.Participants
{
 public interface IParticipantAppService:ICrudAppService<ParticipantDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateParticipantDto>
    {
    }
}
