using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MvvmXamarinClassic.Services;

namespace MvvmXamarinClassic.Modules
{
    public class MyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MyService>().As<IMyService>();
        }
    }
}
