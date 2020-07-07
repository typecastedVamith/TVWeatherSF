using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace TVWeatherSF.StepDefinition
{
    class WeatherValidationStep
    {
        [Given(@"I read weatherForcast from ndtv weather website of an metro city")]
        public void GivenIReadWeatherForcastFromNdtvWeatherWebsiteOfAnMetroCity()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I read weatherforcast of of op\tenWeather API of metro city")]
        public void WhenIReadWeatherforcastOfOfOpEnWeatherAPIOfMetroCity()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I validate the weatherforcast from both the sources")]
        public void ThenIValidateTheWeatherforcastFromBothTheSources()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
