using Microsoft.AspNetCore.Mvc.Testing;

namespace EndToEndTests
{
    [TestFixture]
    public class ApiTests
    {
        private WebApplicationFactory<Program> _factory;
        private HttpClient _testClient;
        
        [OneTimeSetUp]
        public void BeforeAll()
        {
            _factory = new WebApplicationFactory<Program>();
            _testClient = _factory.CreateClient();
        }

        [Test]
        public async Task HealthCheck_Returns200()
        {
           HttpResponseMessage actual = await _testClient.GetAsync("/health");
           Assert.That((int)actual.StatusCode, Is.EqualTo(200));
        }
    }
}