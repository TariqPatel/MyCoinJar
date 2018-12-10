using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using MyCoinJarApp.Core.Constants;
using MyCoinJarApp.Core.Models;

namespace MyCoinJarApp.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public MvxCommand AddCoinToJarCommand { get; set; }

        public FirstViewModel()
        {
            AddCoinToJarCommand = new MvxCommand(DoAddCoinToJar);
            _coinList.AddRange(AllowedCoins);
        }

        void DoAddCoinToJar()
        {
            if (CoinJarWeight > ViewConstants.CoinJarMaxAmountInGrams)
            {
                Console.WriteLine("Coin weight exceeded.");
            }

            if (AllowedCoins.Contains(SelectedCoin))
            {
                CoinJarAmount += SelectedCoin.Amount;
                CoinJarWeight += SelectedCoin.Weight;
            }
            else
            {
                Console.WriteLine("Coin not allowed");
            }
        }

        private List<Coin> AllowedCoins = new List<Coin>()
            {
                new Coin("Penny",ViewConstants.PennyAmount,ViewConstants.PennyWeight),
                new Coin("Nickel",ViewConstants.NickelAmount,ViewConstants.NickelWeight),
                new Coin("Dime",ViewConstants.DimeAmount,ViewConstants.DimeWeight),
                new Coin("Quarter",ViewConstants.QuarterAmount,ViewConstants.QuarterWeight),
                new Coin("Half Dollar",ViewConstants.HalfDollarAmount,ViewConstants.HalfDollarWeight)
            };

        private decimal _coinJarAmount;
        public decimal CoinJarAmount
        {
            get { return _coinJarAmount; }
            set { _coinJarAmount = value; RaisePropertyChanged(() => CoinJarAmount); }
        }

        private decimal _coinJarWeight;
        public decimal CoinJarWeight
        {
            get { return _coinJarWeight; }
            set { _coinJarWeight = value; RaisePropertyChanged(() => CoinJarWeight); }
        }

        public string AddToJarString => "Add Coin";

        private List<Coin> _coinList = new List<Coin>()
            {
                new Coin("Dollar",ViewConstants.DollarAmount,ViewConstants.DollarWeight)
            };
        public List<Coin> CoinList
        {
            get { return _coinList; }
            set { _coinList = value; RaisePropertyChanged(() => CoinList); }
        }

        private Coin _selectedCoin = new Coin("Penny", ViewConstants.PennyAmount,ViewConstants.PennyWeight);
        public Coin SelectedCoin
        {
            get { return _selectedCoin; }
            set { _selectedCoin = value; RaisePropertyChanged(() => SelectedCoin); }
        }
    }
}
