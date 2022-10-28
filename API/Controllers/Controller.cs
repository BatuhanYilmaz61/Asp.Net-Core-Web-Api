using Business.InterfaceB;
using Busines.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;

namespace API.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberContoller : ControllerBase
    {
        private IMemberService _memberservice;
        public MemberContoller(IMemberService MemberService)
        {
            _memberservice = MemberService;
        }
        [HttpGet]
        public List<Member> Get()
        {
            return _memberservice.GetAllMembers();


        }
        [HttpGet("{ID}")]
        public Member Get(int ID)
        {
            return _memberservice.GetMemberById(ID);
        }
        [HttpPost("Create")]
        public Member Create([FromBody] Member member)
        {
            return _memberservice.CreateMember(member);
        }
        [HttpPut("Update")]
        public Member Update([FromBody] Member member)
        {
            return _memberservice.UpdateMember(member);
        }
        [HttpDelete("{ID}")]
        public void delete(int ID)
        {
            _memberservice.DeleteMember(ID);
        }
    }
}
