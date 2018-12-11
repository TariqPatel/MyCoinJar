using System;
using System.Collections.Generic;
using System.Linq;
using MvvmCross.Core.ViewModels;
using MyCoinJarApp.Core.Constants;
using MyCoinJarApp.Core.Models;

namespace MyCoinJarApp.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public MvxCommand AddCoinToJarCommand { get; set; }
        public MvxCommand ResetCoinJarCommand { get; set; }

        public FirstViewModel()
        {
            AddCoinToJarCommand = new MvxCommand(DoAddCoinToJar);
            ResetCoinJarCommand = new MvxCommand(DoResetCoinJar);
            _coinList.AddRange(ViewConstants.AllowedCoins);
        }

        public void InitVariables()
        {
            _coinJarAmountString = ViewConstants.ZeroDollarString;
            _coinJarErrorString = string.Empty;
            _coinJarAmount = 0.00m;
            _coinJarWeight = 0.00m;
        }

        void DoResetCoinJar()
        {
            CoinJarAmount = 0.00m;
            CoinJarWeight = 0.00m;
        }

        void DoAddCoinToJar()
        {
            if (CoinJarWeight > ViewConstants.CoinJarMaxAmountInGrams)
            {
                CoinJarErrorString = ViewConstants.CoinWeightExceededErrorMessage;
                return;
            }

            var match = ViewConstants.AllowedCoins.FirstOrDefault(name => name.Name.Equals(SelectedCoin.Name));

            if (match != null)
            {
                CoinJarAmount += SelectedCoin.Amount;
                CoinJarWeight += SelectedCoin.Weight;
                CoinJarErrorString = string.Empty;
            }
            else
            {
                CoinJarErrorString = ViewConstants.InvalidCoinErrorMessage;
            }
        }

        private string _coinJarAmountString = ViewConstants.ZeroDollarString;
        public string CoinJarAmountString
        {
            get { return _coinJarAmountString; }
            set { _coinJarAmountString = value; RaisePropertyChanged(() => CoinJarAmountString); }
        }

        private string _coinJarErrorString;
        public string CoinJarErrorString
        {
            get { return _coinJarErrorString; }
            set { _coinJarErrorString = value; RaisePropertyChanged(() => CoinJarErrorString); }
        }

        private decimal _coinJarAmount;
        public decimal CoinJarAmount
        {
            get { return _coinJarAmount; }
            set
            {
                _coinJarAmount = value;
                RaisePropertyChanged(() => CoinJarAmount);
                CoinJarAmountString = "$" + CoinJarAmount.ToString();
            }
        }

        private decimal _coinJarWeight;
        public decimal CoinJarWeight
        {
            get { return _coinJarWeight; }
            set { _coinJarWeight = value; RaisePropertyChanged(() => CoinJarWeight); }
        }

        public string AddToJarString => ViewConstants.AddCoinString;
        public string ResetJarString => ViewConstants.ResetJarString;
        public string CoinJarAmountDescriptionString => ViewConstants.CoinJarAmountDescriptionString;

        private MvxObservableCollection<Coin> _coinList = new MvxObservableCollection<Coin>()
            {
                new Coin("Dollar",ViewConstants.DollarAmount,ViewConstants.DollarWeight)
            };

        public MvxObservableCollection<Coin> CoinList
        {
            get { return _coinList; }
            set { _coinList = value; RaisePropertyChanged(() => CoinList); }
        }

        private Coin _selectedCoin = new Coin("Penny", ViewConstants.PennyAmount, ViewConstants.PennyWeight);
        public Coin SelectedCoin
        {
            get { return _selectedCoin; }
            set { _selectedCoin = value; RaisePropertyChanged(() => SelectedCoin); }
        }
    }
}
