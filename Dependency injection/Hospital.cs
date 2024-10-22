using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection
{
    public class Hospital : IHospital
    {
        public void Cure(IPerson person)
        {
            Console.WriteLine("Cure person");
        }
    }
}
