﻿using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);


        List<Person> GetList();



       public bool CheckPerson(Person person);
       
    }
}
