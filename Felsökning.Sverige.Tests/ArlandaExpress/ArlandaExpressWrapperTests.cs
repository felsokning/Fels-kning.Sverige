namespace Felsökning.Sverige.Tests.ArlandaExpress
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ArlandaExpressWrapperTests
    {
        [TestMethod]
        public void ArlandaExpressWrapper_ctor()
        {
            var sut = new ArlandaExpressWrapper();

            sut.Should().NotBeNull();
            sut.Should().BeOfType<ArlandaExpressWrapper>();
            sut.HttpClient.Should().NotBeNull();
        }

        [TestMethod]
        public async Task ArlandaExpressWrapper_GetDeparturesAsync_Succeeds()
        {
            var sut = new ArlandaExpressWrapper();

            var stockholmResults = await sut.GetDeparturesAsync(City.Stockholm);
            stockholmResults.Should().NotBeNull();
            stockholmResults.Count.Should().BeGreaterThanOrEqualTo(0);
            var firstStockholmResult = stockholmResults[0];
            firstStockholmResult.Should().NotBeNull();
            firstStockholmResult.ArrivalDate.Should().NotBeNullOrWhiteSpace();
            firstStockholmResult.ArrivalDayOfWeek.Should().NotBeNullOrWhiteSpace();
            firstStockholmResult.ArrivalTime.Should().NotBeNullOrWhiteSpace();
            firstStockholmResult.DepartureDate.Should().NotBeNullOrWhiteSpace();
            firstStockholmResult.DepartureDayOfWeek.Should().NotBeNullOrWhiteSpace();
            firstStockholmResult.DepartureTime.Should().NotBeNullOrWhiteSpace();
            firstStockholmResult.TimeLeft.Should().BeGreaterThanOrEqualTo(0);

            var arlandaResults = await sut.GetDeparturesAsync(City.Arlanda);
            arlandaResults.Should().NotBeNull();
            arlandaResults.Count.Should().BeGreaterThanOrEqualTo(0);
            var firstArlandaResult = arlandaResults[0];
            firstArlandaResult.ArrivalDate.Should().NotBeNullOrWhiteSpace();
            firstArlandaResult.ArrivalDayOfWeek.Should().NotBeNullOrWhiteSpace();
            firstArlandaResult.ArrivalTime.Should().NotBeNullOrWhiteSpace();
            firstArlandaResult.DepartureDate.Should().NotBeNullOrWhiteSpace();
            firstArlandaResult.DepartureDayOfWeek.Should().NotBeNullOrWhiteSpace();
            firstArlandaResult.DepartureTime.Should().NotBeNullOrWhiteSpace();
            firstArlandaResult.TimeLeft.Should().BeGreaterThanOrEqualTo(0);
        }
    }
}