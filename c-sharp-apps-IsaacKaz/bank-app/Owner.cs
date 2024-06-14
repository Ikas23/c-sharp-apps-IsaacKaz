using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_IsaacKaz.bank_app
{
    public class Owner
    {
        public string firstName;
        public string LastName;

        public string GetFirstName() { return firstName; }
        public string GetLastName() { return LastName; }

        public Owner(string firsName, string lastName)
        {
            this.firstName = firsName;
            this.LastName = lastName;
        }
    }
}
