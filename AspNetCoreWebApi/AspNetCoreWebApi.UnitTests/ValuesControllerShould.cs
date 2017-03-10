using AspNetCoreWebApi.Controllers;
using NUnit.Framework;

namespace AspNetCoreWebApi.UnitTests
{
    [TestFixture]
    public class ValuesControllerShould
    {
        [TestCase(1)]
        public void ValuesController(int id)
        {
            var controller = new ValuesController();

            var response = controller.Get(id);

            Assert.That("value", Is.EqualTo(response));
        }
    }
}
