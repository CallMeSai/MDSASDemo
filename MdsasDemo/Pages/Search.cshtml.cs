using MdsasDemo.Data;
using MdsasDemo.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using UIHelpers;

namespace MdsasDemo.Pages
{
    [BindProperties]
    public class SearchModel : PageModel
    {
        private readonly IPatientRepository patientRepository;

        public Domain.ViewModels.SearchViewModel SearchPatient { get; set; }

        public SearchModel(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        public async Task OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var result  = await patientRepository.GetPatientAsync(SearchPatient);
                ModelState.SetModelValue("Forename", result.Forename, result.Forename);
                ModelState.SetModelValue("Surname", result.Surname, result.Surname);
                ModelState.SetModelValue("DateOfBirth", result.DateOfBirth.ToString("d"), result.DateOfBirth.ToString("d"));
                return Page();
            }

            return RedirectToAction("/index");

        }

    }
}