using MdsasDemo.Data.Interfaces;
using MdsasDemo.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using UIHelpers;

namespace MdsasDemo.Pages
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        private readonly IValidation validation;
        private readonly IPatientRepository patientRepository;

        public Domain.ViewModels.RegisterViewModel RegisterPatient { get; set; }

        public RegisterModel(IValidation validation, IPatientRepository patientRepository)
        {
            this.validation = validation;
            this.patientRepository = patientRepository;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {

                var result = await validation.UniqueNumberAsync(RegisterPatient.UniqueNumber);

                if (!result)
                {
                    ModelState.AddModelError("RegisterPatient.UniqueNumber","Invalid Unique Number");
                    return Page();
                }

                await patientRepository.AddPatientAsync(RegisterPatient);

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}