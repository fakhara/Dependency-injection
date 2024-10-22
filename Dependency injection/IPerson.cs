namespace Dependency_injection
{
    public interface IPerson
    {
        IEducationalInstitution School { set; }

        void GetTreatment(IHospital hospital);
        void Study();
        void TakeRefuge();
    }
}