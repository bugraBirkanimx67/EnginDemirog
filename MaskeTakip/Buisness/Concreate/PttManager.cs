using Buisness.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concreate
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;


        public PttManager(IApplicantService applicantService)//constroctor new yapıldığında çalışır 

        {
            _applicantService = applicantService;
        }


        public void GiveMask(Person person)
        {
           
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirsName+"için maske verildi");
            }
            else Console.WriteLine(person.FirsName + "için maske VERİLEMEDİ");

        }
    }
}
