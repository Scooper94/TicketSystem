using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Models
{
    public class User : IUser
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public UserRoles Role { get; set; }
    }
}
