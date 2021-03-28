using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoAPI.BizLogic;
using Microsoft.AspNetCore.Mvc;

namespace demoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        
            private IMemberHandler _memberHandler;

            public MemberController(IMemberHandler memberHandler)
            {
                _memberHandler = memberHandler;
            }

            [HttpGet]
            [Route("/api/member/memberbygender/{gender}")]
            public List<Member> FilterMemberByGender(string gender)
            {
                return _memberHandler.FilterMemberByGender(gender);
            }

            [HttpGet]
            [Route("/api/member/theoldestmember")]
            public Member ReturnTheOldestMember()
            {
                return _memberHandler.ReturnTheOldestMember();
            }

            [HttpGet]
            [Route("/api/member/memberbyplace/{place}")]
            public List<Member> FilterMemberByBirthPlace(string place)
            {
                return _memberHandler.FilterMemberByBirthPlace(place);
            }
            
            [HttpGet]
            [Route("/api/member/getfullname")]
            public List<string> GetMemberWithFullNameOnly()
            {
                return _memberHandler.GetMemberWithFullNameOnly();
            }
            
            [HttpGet]
            [Route("/api/member/getmemberbyyear/{year}")]
            public List<Member> FilterMemberByBirthYear(int year)
            {
                return _memberHandler.FilterMemberByBirthYear(year);
            }
        
            [HttpGet]
            [Route("/api/member/getmemberlessthanyear/{year}")]
            public List<Member> FilterMemberByBirthYearLessThan(int year)
            {
                return _memberHandler.FilterMemberByBirthYearLessThan(year);
            }

            [HttpGet]
            [Route("/api/member/getmembergreaterthanyear/{year}")]
            public List<Member> FilterMemberByBirthYearGreaterThan(int year)
            {
                return _memberHandler.FilterMemberByBirthYearGreaterThan(year);
            }

            [HttpGet]
            [Route("/api/member/getmembergraduated")]
            public List<Member> GetMemberIsGraduated()
            {
                return _memberHandler.GetMemberIsGraduated();
            }

            [HttpPost]
            [Route("/api/member/addmember")]
            public List<Member> Post(Member member)
            {
                return _memberHandler.AddNewMember(member);
            }

            [HttpDelete]
            [Route("/api/member/deletemember/{name}")]
            public List<Member> Delete(string name)
            {
                return _memberHandler.DeleteMember(name);
            }
        
    }
}