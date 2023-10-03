using Azure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SplitwiseAbp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;
using static Volo.Abp.Identity.Settings.IdentitySettingNames;

namespace SplitwiseAbp.Groups
{
    public class CustomUserGroupService : ApplicationService
    {
        private readonly SplitwiseAbpDbContext _splitwiseAbpContext;

        private readonly UserManager<IdentityUser> _userManager;
        public CustomUserGroupService(SplitwiseAbpDbContext splitwiseAbpDbContext, UserManager<IdentityUser> userManager)
        {
            _splitwiseAbpContext = splitwiseAbpDbContext;
            _userManager = userManager;

        }
        public async Task<ListResultDto<UserGroupDto>> GetAllUsersAsync(string groupId)
        {
            var groupUsers = await _splitwiseAbpContext.UserGroups.Where(u => u.GroupId.ToString() == groupId).Select(g =>
            new UserGroupDto
            {
                GroupId = g.GroupId,
                UserId = g.UserId,
            }).ToListAsync();
            return new ListResultDto<UserGroupDto>(groupUsers);
        }

        public async Task<ListResultDto<GroupOutputDto>> GetAllGroupsAsync(string userId)
        {
            var userGroups = await _splitwiseAbpContext.UserGroups.Where(u => u.UserId.ToString() == userId).Select
                (g => new UserGroupDto
                {
                    GroupId = g.GroupId,
                    UserId = g.UserId,
                }).ToListAsync();
            var result = new List<GroupOutputDto>();
            foreach (var group in userGroups)
            {
                var groupInfo = await _splitwiseAbpContext.Groups.Where(u => u.Id == group.GroupId).Select
                    (p => new GroupOutputDto
                    {
                        Name =p.Name,
                        Description =p.Description,
                        CreationTime =p.CreationTime,
                    }).ToListAsync();
                result.AddRange(groupInfo);
            }
            return new ListResultDto<GroupOutputDto>(result);
        }
    }
}
