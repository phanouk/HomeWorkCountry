using HomeWorkCountry.Data;
using HomeWorkCountry.Models;

namespace HomeWorkCountry.Services
{
    public class MemberService : IMemberService
    {
        public List<TeamMembers> GetTeamMembers()
        {
             MemberSeed memberSeed = new MemberSeed();
            return memberSeed.member;
        }
    }
    public interface IMemberService
    {
        public List<TeamMembers> GetTeamMembers();
    }
}
