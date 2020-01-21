using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using WinAppDriverDemo.Hooks;
using WinAppDriverDemo.Pages;

namespace WinAppDriverDemo
{
    [TestClass]
    public class UnitTest1 : TestInitialize
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalcPage calcPage = new CalcPage();
            calcPage.PerformAddition();
        }
    }
}
