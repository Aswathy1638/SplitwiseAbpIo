using Microsoft.AspNetCore.Identity;
using SplitwiseAbp.EntityFrameworkCore;
using SplitwiseAbp.FriendShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace SplitwiseAbp.Friend
{
    public class CustomFriendsAppServices : ApplicationService
    {
        private readonly SplitwiseAbpDbContext _splitwiseAbpContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICurrentUser _currentUser;
        public CustomFriendsAppServices(SplitwiseAbpDbContext splitwiseAbpContext, UserManager<IdentityUser> userManager, ICurrentUser currentUser)
        {
            _splitwiseAbpContext = splitwiseAbpContext;
            _userManager = userManager;
            _currentUser = currentUser;
        }

        public async Task<Friends> AddFriendAsync(string friendId)
        {
            var friendName = await _userManager.FindByIdAsync(friendId);
            var CurrentUserName = _currentUser.UserName;
           
            var  CurrentUserId = _currentUser.GetId();
           // var currentUserName = await _userManager.FindByIdAsync(_currentUser.UserName);
            

            var newFriend = new Friends
            {
              Id = Guid.NewGuid(),
              UserId = CurrentUserId,
              UserName = CurrentUserName,
              FriendId = friendName.Id,
              FriendName=friendName.UserName
            };

             _splitwiseAbpContext.Add(newFriend);
           await _splitwiseAbpContext.SaveChangesAsync();

            var messages = ObjectMapper.Map<Friends, FriendsDto>(newFriend);

            return newFriend;

        }

    }
}
