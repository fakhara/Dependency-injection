using Autofac;

namespace Dependency_injection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Home home = new Home(); //Constructor dependency injection object
             Person person = new Person(home);
             person.TakeRefuge();
             person.School = new College();//Property dependency injection object
             person.Study();
             person.GetTreatment(new Hospital());*/

            var container = ContainerConfiguration.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                IPerson person = scope.Resolve < IPerson>();
                person.TakeRefuge();
                person.School = scope.Resolve<IEducationalInstitution>();
                person.Study();
                person.GetTreatment(scope.Resolve<IHospital>());
            }
        }
    }
}