using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class CertificationSteps
    {
        //Add Certification
        [Given(@"User try to add new Certification on profile page")]
        public void GivenUserTryToAddNewCertificationOnProfilePage()
        {
            //Add Certification
            Certification certiobj = new Certification();
            certiobj.EnterCertification();
            

        }
        [When(@"User click on Add Certification button")]
        public void WhenUserClickOnAddCertificationButton()
        {
            //Add Certification
            Certification certiobj = new Certification();
            certiobj.AddNewCertification();
            
        }
        [Then(@"User should able to add new Certification successfully")]
        public void ThenUserShouldAbleToAddNewCertificationSuccessfully()
        {
            //Verify Added Certification
            Certification certiobj = new Certification();
            certiobj.VerifyCertification();
        }


        //Edit Certification
        [Given(@"User try to edit the Certification record")]
        public void GivenUserTryToEditTheCertificationRecord()
        {
            //Edit  Certification
            Certification certiobj = new Certification();
            certiobj.EditCertification();
            
        }
        [When(@"User click on update Certification button")]
        public void WhenUserClickOnUpdateCertificationButton()
        {
            //Edit  Certification
            Certification certiobj = new Certification();
            certiobj.UpdateCertification();
           
        }
        [Then(@"User should able to edit Certification successfully")]
        public void ThenUserShouldAbleToEditCertificationSuccessfully()
        {
            //Verify Edited  Certification
            Certification certiobj = new Certification();
            certiobj.VerifyEditedCertification();
        }


        //Delete Certification
        [Given(@"User should able to Delete Certification sucessfully")]
        public void GivenUserShouldAbleToDeleteCertificationSucessfully()
        {
            //Delete Certification
            Certification certiobj = new Certification();
            certiobj.DeleteCertification();
        }

    }

}
