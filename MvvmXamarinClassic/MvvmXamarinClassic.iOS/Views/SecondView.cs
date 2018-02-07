using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

namespace MvvmXamarinClassic.iOS.Views
{
    public partial class SecondView : MvxViewController
    {
        public SecondView() : base("SecondView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<SecondView, ViewModels.SecondViewModel>();
            set.Bind(TextField).To(vm => vm.Text);
            set.Apply();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}