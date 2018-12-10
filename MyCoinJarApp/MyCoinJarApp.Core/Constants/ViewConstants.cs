using System;
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

        public static readonly decimal PennyAmount = 1m;
        public static readonly decimal NickelAmount = 5m;
        public static readonly decimal DimeAmount = 10m;
        public static readonly decimal QuarterAmount = 25m;
        public static readonly decimal HalfDollarAmount = 50m;
        public static readonly decimal DollarAmount = 100m;
    }
}
