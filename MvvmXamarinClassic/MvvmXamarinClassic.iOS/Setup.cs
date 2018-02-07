using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Platform;
using System;
using System.Collections.Generic;
using MvvmXamarinClassic.iOS.Services;
using UIKit;
using MvvmXamarinClassic.Services;
using MvvmXamarinClassic.Bootstrapping;
using Autofac.Extras.MvvmCross;

namespace MvvmXamarinClassic.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }
        
        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
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
            mappedTypes.Add(typeof(PlatformService_iOS), typeof(IPlatformService));
            Bootstrapper bootstrapper = new Bootstrapper();
            var container = bootstrapper.Build(mappedTypes);
            return new AutofacMvxIocProvider(container);
        }
    }
}
