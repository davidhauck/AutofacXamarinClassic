using System;
using System.Collections.Generic;
using System.Text;
using MvvmXamarinClassic.Services;

namespace MvvmXamarinClassic.iOS.Services
{
    public class PlatformService_iOS : IPlatformService
    {
        public string GetPlatform()
        {
            return "iOS";
        }
    }
}
