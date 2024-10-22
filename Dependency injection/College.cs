using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection
{
    public class College : IEducationalInstitution
    {
        public void Teach(IPerson person)
        {
            Console.WriteLine("Educate person in College.");
        }
    }
}
