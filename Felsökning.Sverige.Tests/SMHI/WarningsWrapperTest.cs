// ----------------------------------------------------------------------
// <copyright file="WarningsWrapperTest.cs" company="Felsökning">
//      Copyright © Felsökning. All rights reserved.
// </copyright>
// <author>John Bailey</author>
// ----------------------------------------------------------------------
namespace Felsökning.Sverige.Tests.SMHI
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class WarningsWrapperTest
    {
        [TestMethod]
        public void WarningsWrapper_ctor()
        {
            var sut = new WarningsWrapper();

            sut.Should().NotBeNull();
            sut.Should().BeOfType<WarningsWrapper>();

            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.BaseAddress.Should().Be("https://opendata-download-warnings.smhi.se/ibww/api/version/");
            sut.HttpClient.DefaultRequestVersion.Should().Be(HttpVersion.Version11);
            sut.HttpClient.DefaultVersionPolicy.Should().Be(HttpVersionPolicy.RequestVersionOrHigher);
        }

        [TestMethod]
        public void WarningsWrapper_ctor_With_ApiVersion()
        {
            var sut = new WarningsWrapper("latest");

            sut.Should().NotBeNull();
            sut.Should().BeOfType<WarningsWrapper>();

            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.BaseAddress.Should().Be("https://opendata-download-warnings.smhi.se/ibww/api/version/");
            sut.HttpClient.DefaultRequestVersion.Should().Be(HttpVersion.Version11);
            sut.HttpClient.DefaultVersionPolicy.Should().Be(HttpVersionPolicy.RequestVersionOrHigher);
        }

        [TestMethod]
        public async Task GetRecentWarningsAsync_Succeeds()
        {
            var sut = new WarningsWrapper();

            sut.Should().NotBeNull();
            sut.Should().BeOfType<WarningsWrapper>();

            sut.HttpClient.Should().NotBeNull();
            sut.HttpClient.BaseAddress.Should().Be("https://opendata-download-warnings.smhi.se/ibww/api/version/");
            sut.HttpClient.DefaultRequestVersion.Should().Be(HttpVersion.Version11);
            sut.HttpClient.DefaultVersionPolicy.Should().Be(HttpVersionPolicy.RequestVersionOrHigher);

            var result = await sut.GetRecentWarningsAsync();
            
            result.Should().NotBeNull();
            result.Should().BeOfType<List<WarningsResult>>();
            result.Count.Should().BeGreaterThan(0);

            var warning = result[0];
            warning.Should().NotBeNull();

            warning.Id.Should().NotBe(0);
            warning.WarningAreas.Should().NotBeNull()
                .And.HaveCountGreaterThan(0);

            warning.Descriptions.Should().NotBeNull();
            _ = warning.NormalProbability;

            warning.Event.Should().NotBeNull();
            var warningEvent = warning.Event;
            warningEvent.Should().NotBeNull();
            warningEvent.Code.Should().NotBeNullOrWhiteSpace();
            warningEvent.English.Should().NotBeNullOrWhiteSpace();
            warningEvent.MhoClassification.Should().NotBeNull();
            warningEvent.Svenska.Should().NotBeNullOrWhiteSpace();

            var warningArea = warning.WarningAreas[0];
            warningArea.Should().NotBeNull();
            warningArea.Area.Should().NotBeNull();
            warningArea.AreaName.Should().NotBeNull();
            warningArea.AffectedAreas.Should().NotBeNull()
                .And.HaveCountGreaterThan(0);
            warningArea.Descriptions.Should().NotBeNull()
                .And.HaveCountGreaterThan(0);
            warningArea.Id.Should().BeGreaterThan(0);
            warningArea.EventDescription.Should().NotBeNull();
            warningArea.WarningLevel.Should().NotBeNull();
        }
    }
}