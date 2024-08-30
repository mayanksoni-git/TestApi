using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Model;

namespace TestApi.Repository
{
    public class PatientRepository : IPatient
    {
        List<Patient> lisPatient = new List<Patient>
        {
            new Patient{Id=1, Name="Nitya", Age=21, MobileNo="96585859651" },
            new Patient{Id=2, Name="Nitya1", Age=22, MobileNo="96585859652" },
            new Patient{Id=3, Name="Nitya2", Age=23, MobileNo="96585859653" },
        };
        public List<Patient> GetAllPatient()
        {
            return lisPatient;
        }

        public Patient GetPatient(int id)
        {
            return lisPatient.FirstOrDefault(x => x.Id == id);
        }

        public void InsertPatient(Patient patient)
        {

        }
    }
}
