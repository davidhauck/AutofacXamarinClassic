using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MvvmXamarinClassic.Modules;

namespace MvvmXamarinClassic.Bootstrapping
{
    public class Bootstrapper
    {
        public IContainer Build(Dictionary<Type, Type> mappedTypes)
        {
            var cb = new ContainerBuilder();
            cb.RegisterModule<MyModule>();
            if (mappedTypes != null && mappedTypes.Any())
            {
                cb.RegisterModule(new MappedTypeModule(mappedTypes));
            }
            return cb.Build();
        }
    }
}
