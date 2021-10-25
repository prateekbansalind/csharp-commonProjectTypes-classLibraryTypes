using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkLib
{
    public class Generators
    {
        public string WelcomeMessage(string Prefix, string LastName)
        {
            return $"You are welcome {Prefix} {LastName}.";
        }

        public string FarewellMessage(string Prefix, string LastName)
        {
            return $"I hope you had a good time with us {Prefix} {LastName}";
        }

    }
}
