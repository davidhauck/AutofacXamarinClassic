using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmXamarinClassic.Services;

namespace MvvmXamarinClassic.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IMyService _myService;
        private IPlatformService _platformService;
        private IMvxNavigationService _navigator;

        public MainViewModel(IMyService myService, IPlatformService platformService, IMvxNavigationService navigator)
        {
            _myService = myService;
            _platformService = platformService;
            _navigator = navigator;
        }
        
        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = _platformService.GetPlatform();
        }

        public IMvxCommand GoToSecondPageCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    _navigator.Navigate<SecondViewModel>();
                });
            }
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}