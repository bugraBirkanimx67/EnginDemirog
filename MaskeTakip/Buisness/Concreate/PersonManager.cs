using Buisness.Abstract;
using Entities.Concreate;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concreate
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);


            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentitiy,person.FirsName ,person.NameLast,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}
