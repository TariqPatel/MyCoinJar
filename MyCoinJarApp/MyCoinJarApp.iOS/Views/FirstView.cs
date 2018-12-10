using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MyCoinJarApp.Core.ViewModels;

namespace MyCoinJarApp.iOS.Views
{
    [MvxFromStoryboard]
    public partial class FirstView : MvxViewController
    {
        public FirstView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
           
            set.Apply();
        }
    }
}
