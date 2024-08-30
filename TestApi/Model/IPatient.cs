using System.Collections.Generic;
using TestApi.Model;

namespace TestApi.Model
{
    public interface IPatient
    {
        List<Patient> GetAllPatient();
        Patient GetPatient(int id);
    }
}