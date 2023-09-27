using AutoMapper;
using SplitwiseAbp.Groups;
using System.Text.RegularExpressions;

namespace SplitwiseAbp;

public class SplitwiseAbpApplicationAutoMapperProfile : Profile
{
    public SplitwiseAbpApplicationAutoMapperProfile()
    {
        CreateMap<Groups.Group, GroupDto>();
        CreateMap<CreateUpdateGroupDto, Groups.Group>();

        CreateMap<UserGroup, UserGroupDto>();
        CreateMap<CreateUpdateUserGroupDto,UserGroup>();
    }
}
