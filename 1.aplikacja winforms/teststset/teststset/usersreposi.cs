using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teststset
{
    public class usersreposi
    {
        public List<user> users { get; set; }
     
        public usersreposi() 
        {
           
            users = new List<user>();
            users.Add(new user {login = "admin", password="admin" });
            users.Add(new user { login = "jupiter303", password = "ilovewarcrimes123" });

        }

    }
}
