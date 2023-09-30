using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SplitwiseAbp.Participants
{
    public class ParticipantAppService : CrudAppService<Participant, ParticipantDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateParticipantDto>, IParticipantAppService
    {
        public ParticipantAppService(IRepository<Participant, Guid> repository) : base(repository)
        {
        }
    }
}
