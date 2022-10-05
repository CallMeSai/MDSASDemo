using MdsasDemo.Data.Interfaces;
using MdsasDemo.Domain;
using MdsasDemo.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MdsasDemo.Data.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DemoContext demoContext;

        public PatientRepository(DemoContext demoContext)
        {
            this.demoContext = demoContext;
        }

        public async Task AddPatientAsync(RegisterViewModel registerViewModel)
        {
            var patient = new Patient()
            {
                Id = registerViewModel.Id,
                Forename = registerViewModel.Forename,
                Surname = registerViewModel.Surname,
                UniqueNumber = registerViewModel.UniqueNumber,
                DateOfBirth = registerViewModel.DateOfBirth
            };

            await this.demoContext.Patients.AddAsync(patient);
            await demoContext.SaveChangesAsync();
        }

        public async Task<SearchViewModel> GetPatientAsync(SearchViewModel searchViewModel)
        {
            var uniqueNumber = searchViewModel.UniqueNumber;
            var query = await demoContext.Patients.Where(o => o.UniqueNumber == uniqueNumber).FirstOrDefaultAsync();
            
            var result = new SearchViewModel()
            {
                UniqueNumber = query.UniqueNumber,
                Forename = query.Forename,
                Surname = query.Surname,
                Id = query.Id,
                DateOfBirth = query.DateOfBirth
            };

            return result;          
        }

        public async Task<IEnumerable<SearchViewModel>> GetAllPatientsAsync()
        {
            var query = await demoContext.Patients.ToListAsync();

            var result = new List<SearchViewModel>();

            foreach(var patient in query)
            {
                result.Add(new SearchViewModel()
                {
                    UniqueNumber = patient.UniqueNumber,
                    Forename = patient.Forename,
                    Surname = patient.Surname,
                    DateOfBirth = patient.DateOfBirth
                });
            }

            return result;
        }
    }
}