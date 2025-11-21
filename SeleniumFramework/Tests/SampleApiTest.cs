using NUnit.Framework;
using SeleniumFramework.Api;

namespace SeleniumFramework.Tests
{
    public class SampleApiTest
    {
        private SampleApiService _apiService;

        [SetUp]
        public void Setup()
        {
            _apiService = new SampleApiService();
        }

        [Test]
        public void GetSampleDataTest()
        {
            var response = _apiService.GetSampleData();
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }
    }
}