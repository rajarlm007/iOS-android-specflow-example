using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace IosAndroidSpecflowExample.Pages
{
    public class FireApp : BasePage
    {
        [FindsByAndroidUIAutomator(ID = "acquaintanceEditButton")]
        [FindsByIOSUIAutomation(ID = "Edit")]
        private IMobileElement<AppiumWebElement> _editAcquintanceButton;

        [FindsByAndroidUIAutomator(ID = "com.honeywell.glss.inspectionmanagerdev:id/callGraph")]
        private IMobileElement<AppiumWebElement> loginButton;

       [FindsByAndroidUIAutomator(XPath = "//*[@resource-id='i0116']")]
        private IMobileElement<AppiumWebElement> enterEmailAddress;

        //[FindsByAndroidUIAutomator(ID = "idSIButton9")]
        [FindsByAndroidUIAutomator(XPath = "//*[@resource-id='idSIButton9']")]
        private IMobileElement<AppiumWebElement> nextButtonElement;

        //[FindsByAndroidUIAutomator(ID = "i0118")]
        [FindsByAndroidUIAutomator(XPath = "//*[@resource-id='i0118']")]
        private IMobileElement<AppiumWebElement> enterPassword;

        //[FindsByAndroidUIAutomator(ID = "idSIButton9")]
        [FindsByAndroidUIAutomator(XPath = "//*[@resource-id='idSIButton9']")]
        private IMobileElement<AppiumWebElement> signInButton;

        [FindsByAndroidUIAutomator(XPath = "//XCUIElementTypeButton[@name='Allow']")]
        private IMobileElement<AppiumWebElement> allowPopUpButton;



        public FireApp()
        {
            PageFactory.InitElements(Driver, this, new AppiumPageObjectMemberDecorator());
        }

        public void LoginAppWithValiidCredentials()
        {
            loginButton.Click();


            Boolean EmailTextField = isElementPresent1(enterEmailAddress);

            if (EmailTextField)
            {
                enterEmailAddress.Click();
                enterEmailAddress.SendKeys("dev.test@devbhonidentity.onmicrosoft.com");
                nextButtonElement.Click();

                enterPassword.Click();
                enterPassword.SendKeys("Honeywell@90");
                signInButton.Click();
            }

            Boolean iselementpresent = isElementPresent1(allowPopUpButton);
            if (iselementpresent)
            {
                allowPopUpButton.Click();
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //wait.Until(alertIsPresent());
                //_mobileDriver.SwitchTo().Alert().Accept();
            }
            else
            {
                Console.WriteLine("Alert is not present");
            }

        }

        public Boolean isElementPresent1(IWebElement by)
        {
            try
            {
                // driver.FindElement(by);
                return @by.Displayed;
                // return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

    }
}
