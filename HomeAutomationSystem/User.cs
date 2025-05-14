using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationSystem
{
    public class User
    {
        public string UserName {  get; set; }
        public string Role {  get; set; }

        public User(string userName, string role)
        {
            UserName = userName;
            Role = role;
        }
    }
}
