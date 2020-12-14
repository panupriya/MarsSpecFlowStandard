using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using RelevantCodes.ExtentReports;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class AvailabilityTargetSteps
    {
        
        [Given(@"I try to add Availabily Time and Target to profile details")]
        public void GivenITryToAddAvailabilyTimeAndTargetToProfileDetails()
        {
            
            //Add profile
            AvailabilityTarget LocAvailobj = new AvailabilityTarget();
            LocAvailobj.EnterDetails();
        }

    }
}
