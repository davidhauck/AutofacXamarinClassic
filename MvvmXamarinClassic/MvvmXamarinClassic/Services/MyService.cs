using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmXamarinClassic.Services
{
    public class MyService : IMyService
    {
        public string GetText()
        {
            return "My Text";
        }
    }
}
