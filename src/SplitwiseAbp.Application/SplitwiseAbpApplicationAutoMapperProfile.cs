using AutoMapper;
using SplitwiseAbp.BalDetails;
using SplitwiseAbp.Expenses;
using SplitwiseAbp.Friend;
using SplitwiseAbp.FriendShips;
using SplitwiseAbp.Groups;
using SplitwiseAbp.Participants;
using SplitwiseAbp.Transactions;
using System.Text.RegularExpressions;
using System.Transactions;


namespace SplitwiseAbp;

public class SplitwiseAbpApplicationAutoMapperProfile : Profile
{
    public SplitwiseAbpApplicationAutoMapperProfile()
    {
        CreateMap<Groups.Group, GroupDto>();
        CreateMap<CreateUpdateGroupDto, Groups.Group>();

        CreateMap<UserGroup, UserGroupDto>();
        CreateMap<CreateUpdateUserGroupDto,UserGroup>();

        CreateMap<Friends,FriendsDto>();
        CreateMap<CreateUodateFriendsDto, Friends>();

        CreateMap<BalDetail,BalDetailDto>();
        CreateMap<CreateUpdateBalDetail, BalDetail>();

        CreateMap<Participant, ParticipantDto>();
        CreateMap<CreateUpdateParticipantDto, Participant>();

        CreateMap<Expense,ExpenseDto>();
        CreateMap<CreateUpdateExpenseDto,Expense>();

        CreateMap<Transactions.Transaction, TransactionDto>();
        CreateMap<CreateUpdateTransactionDto, Transactions.Transaction>();
    }
}
