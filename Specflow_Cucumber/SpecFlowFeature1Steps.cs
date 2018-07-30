using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecNuts;
using SpecNuts.Json;
using System;
using TechTalk.SpecFlow;

namespace SpeckFlow
{
    [Binding]
    public class CalcSteps : ReportingStepDefinitions
    {
        private int result;
        private Calculator calculator = new Calculator();

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            SpecNuts.Reporters.Add(new JsonReporter());

            SpecNuts.Reporters.FinishedReport += (sender, args) => {
                String pathName = "specflow_cucumber_" + DateTime.Now.ToUnixTimestampUtc() + ".json";
                System.IO.File.WriteAllText(pathName, args.Reporter.WriteToString());
                Console.WriteLine("Result File: " + System.IO.Directory.GetCurrentDirectory().ToString() + System.IO.Path.DirectorySeparatorChar + pathName);
            };
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
