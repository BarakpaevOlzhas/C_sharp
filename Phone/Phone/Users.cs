using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Users
    {
        public string Login { get; set; }

        public string PhoneNumber { get; set; }

        public string PassWord { get; set; }

        public void AddUser(string login, string phoneNumber,string passWord)
        {
            Login = login;
            PhoneNumber = phoneNumber;
            PassWord = passWord;
        }

    }
}
