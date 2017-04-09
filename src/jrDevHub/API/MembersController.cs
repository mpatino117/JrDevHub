using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jrDevHub.Models;
using jrDevHub.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace jrDevHub.API
{
    [Route("api/[controller]")]
   
    public class MembersController : Controller
    {
        private IMemberService _mservice;
        public MembersController(IMemberService mservice)
        {
            _mservice = mservice;
        }

        // GET: api/values
        [HttpGet]
        public List<Member> Get()
        {
            var members = _mservice.GetMembers();
            return members;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            var member = _mservice.GetMemberById(id);
            return member;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Member member)
        {
            if(ModelState.IsValid)
            {
                _mservice.AddMember(member);
            }
            else
            {
                BadRequest(ModelState);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mservice.RemoveMenber(id);
        }
    }
}
