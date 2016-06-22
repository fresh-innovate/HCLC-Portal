using hackney.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace hackney.Tests.Persistence.Repositories
{
    [TestClass]
    public class GigRepositoryTests
    {
        [TestInitialize]
        public void TestInitialize()
        {

            var mockContext = new Mock<IApplicationDbContext>();
        }

    }
}
