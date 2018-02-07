using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmXamarinClassic.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public string Text
        {
            get
            {
                return "Second Page Text";
            }
        }
    }
}
