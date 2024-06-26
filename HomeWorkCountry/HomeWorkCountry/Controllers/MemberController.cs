using HomeWorkCountry.Models;
using HomeWorkCountry.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkCountry.Controllers
{
    [ApiController]
    [Route("/")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;
        public MemberController(IMemberService member)
        {
            _memberService = member;
        }
        [HttpGet("api/Team/GetTeamMembers")]
        public List<TeamMembers> GetTeamMemeber() 
        { 
            return _memberService.GetTeamMembers();
        }

    }
}
