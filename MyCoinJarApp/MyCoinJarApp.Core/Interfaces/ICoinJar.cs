using System;
namespace MyCoinJarApp.Core.Interfaces
{
    //Not using this.
    public interface ICoinJar
    {
        void AddCoin(ICoin coin);
        decimal TotalAmount { get; }
        void Reset();
    }
}
