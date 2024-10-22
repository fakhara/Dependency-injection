using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection
{
    public class ContainerConfiguration
    {
        public static IContainer Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Person>().As<IPerson>();
            builder.RegisterType<Home>().As<IHome>();
            builder.RegisterType<Hospital>().As<IHospital>();
            builder.RegisterType<College>().As<IEducationalInstitution>();
            return builder.Build();
        }
    }
}
