// ----------------------------------------------------------------------
// <copyright file="SmhiWrapper.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.Tests.SMHI
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ObservationsWrapperTests
    {
        [TestMethod]
        public void SmhiWrapper_ctor()
        {
            var sut = new ObservationsWrapper();

            sut.Should().NotBeNull();
            sut.Should().BeOfType<ObservationsWrapper>();

            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.BaseAddress.Should().Be("https://opendata-download-metobs.smhi.se/api/version/1.0/");
            sut.HttpClient.DefaultRequestVersion.Should().Be(HttpVersion.Version11);
            sut.HttpClient.DefaultVersionPolicy.Should().Be(HttpVersionPolicy.RequestVersionOrHigher);
        }

        [TestMethod]
        public void SmhiWrapper_ctor_With_ApiVersion()
        {
            var sut = new ObservationsWrapper("latest");

            sut.Should().NotBeNull();
            sut.Should().BeOfType<ObservationsWrapper>();

            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.BaseAddress.Should().Be("https://opendata-download-metobs.smhi.se/api/version/latest/");
            sut.HttpClient.DefaultRequestVersion.Should().Be(HttpVersion.Version11);
            sut.HttpClient.DefaultVersionPolicy.Should().Be(HttpVersionPolicy.RequestVersionOrHigher);
        }

        [TestMethod]
        public async Task GetParameterResourcesAsync_Succeeds()
        {
            var sut = new ObservationsWrapper();

            var resourcesResults = await sut.GetParameterResourcesAsync();

            resourcesResults.Should().NotBeNull();
            resourcesResults.Count.Should().BeGreaterThan(0);
        }

        [TestMethod]
        public async Task GetStationsBasedOnResourceAsync_Succeeds()
        {
            var sut = new ObservationsWrapper();

            var resourcesResults = await sut.GetParameterResourcesAsync();

            resourcesResults.Should().NotBeNull();
            resourcesResults.Count.Should().BeGreaterThan(0);

            var temperatureLastHour = resourcesResults.Find(x => x.Key == "1");
            temperatureLastHour.Should().NotBeNull();
            temperatureLastHour!.GeoBox.Should().NotBeNull();
            temperatureLastHour.Key.Should().Be("1");
            temperatureLastHour.Summary.Should().Be("momentanvärde, 1 gång/tim");
            temperatureLastHour.Title.Should().Be("Lufttemperatur");
            temperatureLastHour.Unit.Should().Be("celsius");
            temperatureLastHour.Updated.Should().NotBeNull();

            var temperatureLinks = temperatureLastHour.Link;
            temperatureLinks.Should().NotBeNull();
            temperatureLinks.Count.Should().BeGreaterThan(0);

            var stationResult = await sut.GetStationsBasedOnResourceAsync(temperatureLastHour!);

            stationResult.Should().NotBeNull();
            stationResult.Count.Should().BeGreaterThan(0);
        }

        [TestMethod]
        public async Task GetResourceDataFromStationAsync_Succeeds()
        {
            var sut = new ObservationsWrapper();

            var resourcesResults = await sut.GetParameterResourcesAsync();

            resourcesResults.Should().NotBeNull();
            resourcesResults.Count.Should().BeGreaterThan(0);

            var temperatureLastHour = resourcesResults.Find(x => x.Key == "1");
            temperatureLastHour.Should().NotBeNull();

            var stationResult = await sut.GetStationsBasedOnResourceAsync(temperatureLastHour!);

            stationResult.Should().NotBeNull();
            stationResult.Count.Should().BeGreaterThan(0);

            var linköpingStation = stationResult.Find(x => x.Id == 85240);

            linköpingStation.Should().NotBeNull();

            var temperatureResults = await sut.GetResourceDataFromStationAsync<Temperatures>(temperatureLastHour!, linköpingStation!);

            temperatureResults.Should().NotBeNull();
            temperatureResults.Value.Count.Should().BeGreaterThan(0);
        }
    }
}