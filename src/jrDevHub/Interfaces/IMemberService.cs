using System.Collections.Generic;
using jrDevHub.Models;

namespace jrDevHub.Services
{
    public interface IMemberService
    {
        void AddMember(Member member);
        Member GetMemberById(int id);
        List<Member> GetMembers();
        void RemoveMenber(int id);
    }
}