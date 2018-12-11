using System;
using MyCoinJarApp.Core.Interfaces;

namespace MyCoinJarApp.Core.Models
{
    public class Coin : ICoin
    {
        public decimal Amount { get;}
        public decimal Weight { get;}
        public string Name { get; }
        public Coin(string name, decimal amount, decimal weight)
        {
            Amount = amount;
            Weight = weight;
            Name = name;
        }
    }
}
