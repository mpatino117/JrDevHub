using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrDevHub.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SlackHandle { get; set; }
        public string JobTitle { get; set; }
        public string Bio { get; set; }
    }
}
