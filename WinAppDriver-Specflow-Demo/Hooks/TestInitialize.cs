using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriverDemo.Base;

namespace WinAppDriverDemo.Hooks
{
    public class TestInitialize
    {

        [TestInitialize]
        public void TestSetup()
        {
            AppiumOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");

            BasePage.WindowsDriver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), desiredCapabilities);
        }

        [TestCleanup]
        public void TearDown()
        {
            if(BasePage.WindowsDriver != null)
            {
                BasePage.WindowsDriver.Quit();
                BasePage.WindowsDriver = null;
            }
        }

    }
}
