using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmXamarinClassic.Services;

namespace MvvmXamarinClassic.Droid.Services
{
    public class PlatformService_Android : IPlatformService
    {
        public string GetPlatform()
        {
            return "Android";
        }
    }
}