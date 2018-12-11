using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using MyCoinJarApp.Core.Constants;
using MyCoinJarApp.Core.ViewModels;
using UIKit;

namespace MyCoinJarApp.iOS.Views
{
    [MvxFromStoryboard]
    public partial class FirstView : MvxViewController<FirstViewModel>
    {
        MvxPickerViewModel _pickerViewModel;
        public FirstView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupPicker();
            SetupNavBar();
            StyleViews();
            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(_pickerViewModel).For(v => v.SelectedItem).To(vm => vm.SelectedCoin);
            set.Bind(CoinAddToJarButton).To(vm => vm.AddCoinToJarCommand);
            set.Bind(CoinResetJarButton).To(vm => vm.ResetCoinJarCommand);
            set.Bind(CoinAmountLabel).For(v => v.Text).To(vm => vm.CoinJarAmountString);
            set.Bind(CoinErrorLabel).For(v => v.Text).To(vm => vm.CoinJarErrorString);
            set.Bind(CoinAmountDescriptionLabel).For(v => v.Text).To(vm => vm.CoinJarAmountDescriptionString);
            set.Apply();
        }

        void SetupPicker()
        {
            _pickerViewModel = new MvxPickerViewModel(CoinPickerView);
            CoinPickerView.Model = _pickerViewModel;
            CoinPickerView.ShowSelectionIndicator = true;
            _pickerViewModel.ItemsSource = ViewModel.CoinList;
        }

        void SetupNavBar()
        {
            CoinNavigationBar.TopItem.Title = ViewConstants.CoinJarTitle;
        }

        void StyleViews()
        {
            CoinAddToJarButton.BackgroundColor = UIColor.Cyan;
            CoinResetJarButton.BackgroundColor = UIColor.Red;
            CoinAddToJarButton.SetTitle(ViewConstants.AddCoinString, UIControlState.Normal);
            CoinResetJarButton.SetTitle(ViewConstants.ResetJarString, UIControlState.Normal);
            CoinResetJarButton.SetTitleColor(UIColor.White, UIControlState.Normal);
        }
    }
}
