using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection
{
    public class Home : IHome
    {
        public void ProvideShelter(IPerson person)
        {
            Console.WriteLine("Stay Home");
        }
    }
}
