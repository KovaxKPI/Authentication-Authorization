using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAuthenticationAuthorization.Models
{
    public enum BuyerType
    {
        none,
        regular,
        golden,
        wholesale
    }
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int? RoleId { get; set; }
        public Role role { get; set; }
        public BuyerType BuyerType { get; set; }
    }
}
