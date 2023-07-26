using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Admin:User
    {
        public bool SuperAdmin;
        public string Section;

        public Admin(string username, string password, bool superadmin,string section):base(username,password)
        {
            SuperAdmin = superadmin;
            Section = section;
        }
        public void GetAdminData()
        {
            Console.WriteLine("Adminin datalari");
            Console.WriteLine($"Username: {UserName}");
            Console.WriteLine($"Superadmin:{SuperAdmin}");
            Console.WriteLine($"Section:{Section}");
        }

    }

}
