using System;
namespace MyCoinJarApp.Core.Interfaces
{
    public interface ICoin
    {
        decimal Amount { get; }
        decimal Weight { get; }
        string Name { get; }
    }
}
