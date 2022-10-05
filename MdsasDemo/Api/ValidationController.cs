using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIHelpers;

namespace MdsasDemo.Api
{
    [Route("[controller]/[action]")]
    public class ValidationController : Controller
    {
        private readonly IValidation validation;

        public ValidationController(IValidation validation)
        {
            this.validation = validation;
        }

        //[HttpGet]
        //public async Task<IActionResult> VerifyUniqueNumber([FromQuery(Name = "RegisterPatient.UniqueNumber")] string uniqueNumber)
        //{
        //    throw new NotImplementedException("Not implemented yet");
        //    var isValid = true;  // or false!
        //    return Json(isValid);
        //}
    }
}