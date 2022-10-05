using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using UIHelpers;

namespace MdsasDemo.Test
{
   
    [TestClass]
    public class ValidationTests
    {
        private readonly IValidation validation = new Validation();

        [TestMethod]
        public async Task Number_7980018931_is_valid()
        {
            var isValid = await validation.UniqueNumberAsync("7980018931");

            Assert.IsTrue(isValid, "Expected 7980018931 to be valid");
        }

        [TestMethod]
        public async Task Number_9999999999_is_valid()
        {
            var isValid = await validation.UniqueNumberAsync("9999999999");

            Assert.IsTrue(isValid, "Expected 9999999999 to be valid");
        }

        [TestMethod]
        public async Task Number_6469207170_is_valid()
        {
            var isValid = await validation.UniqueNumberAsync("6469207170");

            Assert.IsTrue(isValid, "Expected 6469207170 to be valid");
        }

        [TestMethod]
        public async Task Number_12345aa890_is_not_valid()
        {
            var isValid = await validation.UniqueNumberAsync("12345aa890");

            Assert.IsFalse(isValid, "Expected 12345aa890 to be not valid");
        }

        [TestMethod]
        public async Task Number_1234567890_is_not_valid()
        {
            var isValid = await validation.UniqueNumberAsync("1234567890");

            Assert.IsFalse(isValid, "Expected 1234567890 to be not valid");
        }

        [TestMethod]
        public async Task Number_4625557164_is_not_valid()
        {
            var isValid = await validation.UniqueNumberAsync("4625557164");

            Assert.IsFalse(isValid, "Expected 4625557164 to be not valid");
        }

        [TestMethod]
        public async Task Number_4610827452_is_not_valid()
        {
            var isValid = await validation.UniqueNumberAsync("4610827452");

            Assert.IsFalse(isValid, "Expected 4610827452 to be not valid");
        }

        [TestMethod]
        public async Task Number_6325382653_is_not_valid()
        {
            var isValid = await validation.UniqueNumberAsync("6325382653");

            Assert.IsFalse(isValid, "Expected 6325382653 to be not valid");
        }

        [TestMethod]
        public async Task Number_6325382651_is_not_valid()
        {
            var isValid = await validation.UniqueNumberAsync("6325382651");

            Assert.IsFalse(isValid, "Expected 6325382651 to be not valid");
        }
    }
}
