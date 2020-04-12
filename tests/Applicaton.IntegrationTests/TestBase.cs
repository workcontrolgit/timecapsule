using NUnit.Framework;
using System.Threading.Tasks;

namespace timecapsule.Application.IntegrationTests
{
    using static Testing;

    public class TestBase
    {
        
        [SetUp]
        public async Task TestSetUp()
        {
            await ResetState();
        }
    }
}
