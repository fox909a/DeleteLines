using DeleteLinesTest.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

using System;
using System.Diagnostics;

namespace DeleteLinesTest
{
    public class Tests
    {
        private WindowsDriver<WindowsElement> _driver;
        private IAppSettings settings = TestingConfigSettings.GetInstance();

        [SetUp]
        public void Setup()
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", settings.AppID);
            options.AddAdditionalCapability(Environment.MachineName, "WindowsPC");
            _driver = new WindowsDriver<WindowsElement>(new Uri(settings.WindowsApplicationDriverUrl), options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(settings.DefaultWaitTime);
        }

        [Test]
        public void Test1()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }
        
        [Test]
        public void CheckValidPath()
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(settings.DefaultWaitTime));

            _driver.FindElementByAccessibilityId("folderTXTBX").Click();

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(settings.DefaultWaitTime));

            string folderText = _driver.FindElementByAccessibilityId("folderTXTBX").Text;

            Assert.AreEqual(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory).ToString(), folderText);
        }

        [TearDown]
        public void TestCleanup()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }
    }
}