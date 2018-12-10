using System;
namespace MyCoinJarApp.Core
{
    public interface ICoin
    {
        decimal Amount { get; }
        decimal Weight { get; }
        string Name { get; }
    }
}
