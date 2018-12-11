using System;
using System.Collections.Generic;
using MyCoinJarApp.Core.Models;

namespace MyCoinJarApp.Core.Constants
{
    public class ViewConstants
    {
        public static readonly decimal CoinJarMaxAmountInGrams = 1242.08824687m; //29.5735296875g * 42 fluid ounce = 1242.08824687g

        //Amount of coins in grams
        public static readonly decimal PennyWeight = 2.500m;
        public static readonly decimal NickelWeight = 5.000m;
        public static readonly decimal DimeWeight = 2.268m;
        public static readonly decimal QuarterWeight = 5.670m;
        public static readonly decimal HalfDollarWeight = 11.340m;
        public static readonly decimal DollarWeight = 3m; //random amount

        public static readonly decimal PennyAmount = 0.1m;
        public static readonly decimal NickelAmount = 0.5m;
        public static readonly decimal DimeAmount = 0.10m;
        public static readonly decimal QuarterAmount = 0.25m;
        public static readonly decimal HalfDollarAmount = 0.50m;
        public static readonly decimal DollarAmount = 1m;

        public static readonly string CoinWeightExceededErrorMessage = "Coin weight exceeded.";
        public static readonly string InvalidCoinErrorMessage = "Coin not allowed.";
        public static readonly string ZeroDollarString = "$0.00";
        public static readonly string AddCoinString = "Add Coin";
        public static readonly string ResetJarString = "Empty me please...";
        public static readonly string CoinJarTitle = "My Coin Jar";
        public static readonly string CoinJarAmountDescriptionString = "This jar has this much money in it...";

        public static List<Coin> AllowedCoins = new List<Coin>()
            {
                new Coin("Penny",PennyAmount,PennyWeight),
                new Coin("Nickel",NickelAmount,NickelWeight),
                new Coin("Dime",DimeAmount,DimeWeight),
                new Coin("Quarter",QuarterAmount,QuarterWeight),
                new Coin("Half Dollar",HalfDollarAmount,HalfDollarWeight)
            };
    }
}
