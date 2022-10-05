using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UIHelpers
{
    public class Validation : IValidation
    {
        public async Task<bool> UniqueNumberAsync(string uniqueNumber)
        {
            var result = false;

            if (uniqueNumber.Length != 10)
            {
                return result;
            }

            var matches = Regex.Matches(uniqueNumber, @"\D+");

            if(matches.Count > 0) {
                return result;
            }

            var charArray = uniqueNumber.ToCharArray();
            var total = 0;
            var index = 10;

            for (int i = 0; i < 9; i++)
            {
                var character = charArray[i].ToString();
                var number = int.Parse(character);

                total = total + (number * index);

                index--;
            }

            var remainder = total % 11;
            var checkDigit = 11 - remainder;

            if (checkDigit == 11)
            {
                return true;
            }

            if(checkDigit  == 10)
            {
                return result;
            }

            if(checkDigit == int.Parse(charArray[9].ToString()))
            {
                result = true;
            }

            return result;
        }
    }
}