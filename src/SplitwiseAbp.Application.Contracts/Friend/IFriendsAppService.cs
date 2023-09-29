using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SplitwiseAbp.Friend
{
    public interface IFriendsAppService : ICrudAppService<FriendsDto,Guid,PagedAndSortedResultRequestDto,CreateUodateFriendsDto>
    {
    }
}
