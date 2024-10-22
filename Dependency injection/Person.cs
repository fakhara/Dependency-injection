﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection
{
    public class Person : IPerson
    {
        private IHome _home;
        private IEducationalInstitution _school;

        public IEducationalInstitution School
        {
            set
            {
                _school = value;
            }
        }

        public Person(IHome home)
        {
            _home = home;
            _school = new School();
        }
        public void TakeRefuge()
        {
            _home.ProvideShelter(this);
        }
        public void Study()
        {
            if (_school != null)
                _school.Teach(this);
        }
        public void GetTreatment(IHospital hospital)
        {
            hospital.Cure(this);
        }
    }
}
