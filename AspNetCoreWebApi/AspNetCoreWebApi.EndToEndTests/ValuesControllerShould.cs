using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;

namespace AspNetCoreWebApi.EndToEndTests
{
    [TestFixture]
    public class ValuesControllerShould
    {
        private TestServer _server;
        private HttpClient _client;

        [SetUp]
        public void SetUp()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Test]
        public async Task ReturnValue()
        {
            var response = await _client.GetAsync("api/values/5");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.That("value", Is.EqualTo(responseString));
        }
    }
}
