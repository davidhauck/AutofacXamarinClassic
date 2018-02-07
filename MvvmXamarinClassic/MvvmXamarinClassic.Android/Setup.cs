using Android.Content;
using Autofac;
using Autofac.Extras.MvvmCross;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Platform;
using MvvmXamarinClassic.Bootstrapping;
using MvvmXamarinClassic.Modules;
using System.Collections.Generic;
using System;
using MvvmXamarinClassic.Droid.Services;
using MvvmXamarinClassic.Services;

namespace MvvmXamarinClassic.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxIoCProvider CreateIocProvider()
        {
            Dictionary<Type, Type> mappedTypes = new Dictionary<Type, Type>();
            mappedTypes.Add(typeof(PlatformService_Android), typeof(IPlatformService));
            Bootstrapper bootstrapper = new Bootstrapper();
            var container = bootstrapper.Build(mappedTypes);
            return new AutofacMvxIocProvider(container);
        }
    }
}
