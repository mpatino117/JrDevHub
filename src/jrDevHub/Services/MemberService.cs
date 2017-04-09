using jrDevHub.Models;
using jrDevHub.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrDevHub.Services
{
    public class MemberService : IMemberService
    {
        private IGenericRepository _repo;
        public MemberService(IGenericRepository repo)
        {
            _repo = repo;
        }

        //get all members from databse
        public List<Member> GetMembers()
        {
            List<Member> members = _repo.Query<Member>().ToList();
            return members;
        }

        //get a member by their identifier
        public Member GetMemberById(int id)
        {
            Member member = _repo.Query<Member>().Where(m => m.Id == id).FirstOrDefault();
            return member;
        }

        //inject a member into the database
        public void AddMember(Member member)
        {
          if(member.Id == 0)
            {
                _repo.Add(member);
            }
          else
            {
                _repo.Update(member);
            }   
        }

        //remove a memeber from database
        public void RemoveMenber(int id)
        {
            Member member = GetMemberById(id);
            _repo.Delete(member);
        }

    }
}
