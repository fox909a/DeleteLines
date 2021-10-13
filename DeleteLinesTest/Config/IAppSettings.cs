using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteLinesTest.Config
{
    public interface IAppSettings
    {
        public string WindowsApplicationDriverUrl { get; }
        public string AppID { get; }
        public double DefaultWaitTime { get; }
    }
}
