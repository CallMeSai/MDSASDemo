using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UIHelpers
{
    public interface IValidation
    {
        Task<bool> UniqueNumberAsync(string uniqueNumber);
    }
}