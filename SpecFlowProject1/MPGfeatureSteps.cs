using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using sharedLib;
using FluentAssertions;

namespace SpecFlowProject1
{
    [Binding]
    public sealed class MPGsteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public MPGsteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Miles driven is (.*)")]
        public void GivenMilesDrivenIs(int p0)
        {

            float miles = Convert.ToSingle(p0);
            _scenarioContext.Add("miles", miles);
        }

        [Given(@"Gallons used is (.*)")]
        public void GivenGallonsUsedIs(int p0)
        {
            float gallons = Convert.ToSingle(p0);
            _scenarioContext.Add("gallons", gallons);
        }

        [When(@"calc_mpg is called")]
        public void WhenCalc_MpgIsCalled()
        {

            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("mpg", f.calc_mpg(
                   _scenarioContext.Get<float>("miles"),
                   _scenarioContext.Get<float>("gallons")
                   ));
        }

        [Then(@"the fuel efficiency should be (.*)")]
        public void ThenTheFuelEfficiencyShouldBe(float p0)
        {
            var m = _scenarioContext.Get<float>("mpg");
            m.Should().Be(p0);
        }

    }
}