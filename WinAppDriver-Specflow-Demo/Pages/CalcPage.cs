using OpenQA.Selenium.Appium.Windows;
using WinAppDriverDemo.Base;

namespace WinAppDriverDemo.Pages
{
    public class CalcPage : BasePage
    {

        public WindowsElement btnFive => WindowsDriver.FindElementByName("Five");
        public WindowsElement btnSix => WindowsDriver.FindElementByName("Six");
        public WindowsElement btnSeven => WindowsDriver.FindElementByName("Seven");
        public WindowsElement btnPlus => WindowsDriver.FindElementByName("Plus");

        public WindowsElement btnEquals => WindowsDriver.FindElementByName("Equals");


        public void PerformAddition()
        {
            btnFive.Click();
            btnSix.Click();
            btnSeven.Click();
            btnPlus.Click();
            btnFive.Click();
            btnEquals.Click();
        }




    }
}
