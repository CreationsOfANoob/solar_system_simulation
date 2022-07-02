using System;
using Xunit;

namespace Tests
{
    public class TestPlanet
    {
        [Theory]
        [InlineData("Test Planet")]
        [InlineData("Other Test Planet")]
        public void Constructor_Sets_Name(string name)
        {
            var testPlanet = new solar_system_simulation.Planet(name);
            Assert.Equal(name, testPlanet.Name);
        }
    }
}
