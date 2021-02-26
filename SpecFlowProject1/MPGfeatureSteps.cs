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


        [Given(@"gallons used is greater than (.*)")]
        public void GivenGallonsUsedIsGreaterThan(int gallons)
        {
            _scenarioContext.Add("gallons", gallons);
        }

        [Given(@"miles is less than (.*)")]
        public void GivenMilesIsLessThan(int miles)
        {
            _scenarioContext.Add("miles", miles);
        }

        [When(@"it is gasHog\(\) true")]
        public void WhenItIsGasHogTrue()
        {
            FuelEfficiency f = new FuelEfficiency();
            int gallons = _scenarioContext.Get<int>("gallons");
            int miles = _scenarioContext.Get<int>("miles");
            bool gasUse = f.gasHog(miles, gallons);
       
             _scenarioContext.Add("gasUse", gasUse);
           
        }


        [Then(@"gasHog\(\) should return (.*)")]
        public void ThenGasHogShouldReturn(bool p0)
        {
            bool m = _scenarioContext.Get<bool>("gasUse");
            m.Should().Be(p0);
        }





        [Given(@"your MPG is (.*)")]
        public void GivenYourMPGIs(int p0)
        {
            float mpg = Convert.ToSingle(p0);
            _scenarioContext.Add("mpg", mpg);
        }

        [When(@"calcgallons is called")]
        public void WhenCalcgallonsIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("calcGal", f.calcGallons(
                   _scenarioContext.Get<float>("mpg"),
                   _scenarioContext.Get<float>("miles")
                   ));
        }

        [Then(@"the gas used should be (.*)")]
        public void ThenTheGasUsedShouldBe(float p0)
        {
            var m = _scenarioContext.Get<float>("calcGal");
            m.Should().Be(p0);
        }

        [When(@"calcMiles is called")]
        public void WhenCalcMilesIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("calcmiles", f.calcMiles(
                   _scenarioContext.Get<float>("mpg"),
                   _scenarioContext.Get<float>("gallons")
                   ));
        }

        [Then(@"the amount of miles traveled is (.*)")]
        public void ThenTheAmountOfMilesTraveledIs(float p0)
        {
            var m = _scenarioContext.Get<float>("calcmiles");
            m.Should().Be(p0);
        }




        [Given(@"price per gallon is (.*)")]
        public void GivenPricePerFallonIs(int p0)
        {
            float price = Convert.ToSingle(p0);
            _scenarioContext.Add("price", price);
        }

        [Given(@"your card amount is (.*)")]
        public void GivenYourCardAmountIs(int p0)
        {
            float card = Convert.ToSingle(p0);
            _scenarioContext.Add("card", card);
        }

        [When(@"calc_pay is called")]
        public void WhenCalc_PayIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("payment", f.calcPay(
                   _scenarioContext.Get<float>("price"),
                   _scenarioContext.Get<float>("card")
                   ));
        }

        [Then(@"the payment should be (.*)")]
        public void ThenThePaymentShouldBe(int p0)
        {
            var m = _scenarioContext.Get<float>("payment");
            m.Should().Be(p0);
        }





        [Given(@"the tank is (.*)")]
        public void GivenTheTankIs(int p0)
        {
            float tank = Convert.ToSingle(p0);
            _scenarioContext.Add("tank", tank);
        }

        [When(@"calc_fuelUse")]
        public void WhenCalc_FuelUse()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("fuelUse", f.calcFuelUse(
                   _scenarioContext.Get<float>("gallons"),
                   _scenarioContext.Get<float>("tank")
                   ));
        }

        [Then(@"the times stoped should be (.*)")]
        public void ThenTheTimesStopedShouldBe(float p0)
        {
            var m = _scenarioContext.Get<float>("fuelUse");
            m.Should().Be(p0);
        }


    }
}