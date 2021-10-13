using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteLinesTest.Config
{
    public class TestingConfigSettings : IAppSettings
    {

        //needs to be run
        //C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe


        private TestingConfigSettings()
        {
        }

        private static TestingConfigSettings _instance;

        public static TestingConfigSettings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TestingConfigSettings();
            }
            return _instance;
        }

        public string WindowsApplicationDriverUrl
        {
            get
            {
                return @"http://127.0.0.1:4723";
                //return ConfigurationManager.AppSettings["SomeKey"].ToString();
            }
        }

        public string AppID
        {
            get
            {
                return @"C:\Users\William\Source\Repos\DeleteLines\DeleteLines\bin\Debug\DeleteLines.exe";
                //return ConfigurationManager.AppSettings["SomeOtherKey"].ToString();
            }
        }

        public double DefaultWaitTime
        {
            get
            {
                return 5;
                //return ConfigurationManager.AppSettings["SomeOtherKey"].ToString();
            }
        }
    }
}
