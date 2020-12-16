using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class ChangePasswordSteps
    {
        //Reset password
        [Given(@"User should able to reset password")]
        public void GivenUserShouldAbleToResetPassword()
        {
            //Change Password
            ChangePassword ChgpwdObj = new ChangePassword();
            ChgpwdObj.changePassword();
        }
        [Then(@"User should able to reset password successfully")]
        public void ThenUserShouldAbleToResetPasswordSuccessfully()
        {
            //Change Password
            ChangePassword ChgpwdObj = new ChangePassword();
            ChgpwdObj.SavePassword();
        }

        //Set back to old password( before test go to SignInStep and change sedkeys password to NewPassword after test reset it)
        [Given(@"User try to set password")]
        public void GivenUserTryToSetPassword()
        {
            //Set Password back
            ChangePassword ChgpwdObj = new ChangePassword();
            ChgpwdObj.SetPassword();
        }
        [Then(@"User should able to set password successfully")]
        public void ThenUserShouldAbleToSetPasswordSuccessfully()
        {
            //Set Password back
            ChangePassword ChgpwdObj = new ChangePassword();
            ChgpwdObj.SaveSetPassword();
        }

    }
}
