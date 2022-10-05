using MdsasDemo.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MdsasDemo.Data.Interfaces
{
    public interface IPatientRepository
    {
        Task AddPatientAsync(RegisterViewModel registerViewModel);

        Task<SearchViewModel> GetPatientAsync(SearchViewModel searchViewModel);
    }
}