using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using MyCoinJarApp.Core.Models;

namespace MyCoinJarApp.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public MvxCommand AddCoinToJarCommand;

        public FirstViewModel()
        {
            AddCoinToJarCommand = new MvxCommand(DoAddCoinToJar);
        }

        void DoAddCoinToJar()
        {

        }

        public string AddToJarString => "Add Coin";

        private List<RadioButton> _items = new List<RadioButton>()
            {
                new RadioButton("One"),
                new RadioButton("Two"),
                new RadioButton("Three"),
                new RadioButton("Four"),
            };
        public List<RadioButton> Items
        {
            get { return _items; }
            set { _items = value; RaisePropertyChanged(() => Items); }
        }

        private RadioButton _selectedItem = new RadioButton("One");
        public RadioButton SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; RaisePropertyChanged(() => SelectedItem); }
        }
    }
}
