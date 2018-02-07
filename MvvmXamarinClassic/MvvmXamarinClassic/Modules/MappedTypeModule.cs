using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace MvvmXamarinClassic.Modules
{
    public class MappedTypeModule : Module
    {
        private Dictionary<Type, Type> _mappedTypes;

        public MappedTypeModule(Dictionary<Type, Type> mappedTypes)
        {
            _mappedTypes = mappedTypes;
        }

        protected override void Load(ContainerBuilder builder)
        {
            foreach (var mappedType in _mappedTypes)
            {
                builder.RegisterType(mappedType.Key).As(mappedType.Value);
            }
        }
    }
}
