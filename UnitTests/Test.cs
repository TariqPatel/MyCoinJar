using MvvmCross.Tests;
using MyCoinJarApp.Core.Constants;
using MyCoinJarApp.Core.Models;
using MyCoinJarApp.Core.ViewModels;
using NUnit.Framework;
namespace UnitTests
{
    [TestFixture]
    public class Test : MvxIoCSupportingTest
    {
        FirstViewModel vm;
        void TestInit()
        {
            Setup();
            vm = Ioc.IoCConstruct<FirstViewModel>();
        }

        [Test]
        public void ShouldAddNickelWithCorrectAmount()
        {
            // arrange
            TestInit();
            vm.SelectedCoin = new Coin("Nickel", ViewConstants.NickelAmount, ViewConstants.NickelWeight);
           
            // act
            vm.AddCoinToJarCommand.Execute();

            // assert
            Assert.AreEqual(vm.CoinJarAmountString, "$" + ViewConstants.NickelAmount);
        }

        [Test]
        public void ShouldAddNickelWithCorrectWeight()
        {
            // arrange
            TestInit();
            vm.SelectedCoin = new Coin("Nickel", ViewConstants.NickelAmount, ViewConstants.NickelWeight);

            // act
            vm.AddCoinToJarCommand.Execute();

            // assert
            Assert.AreEqual(vm.CoinJarWeight, ViewConstants.NickelWeight);
        }

        [Test]
        public void ShouldGetErrorMessageWhenAddingDollarCoin()
        {
            // arrange
            TestInit();
            vm.SelectedCoin = new Coin("Dollar", ViewConstants.DollarAmount, ViewConstants.DollarWeight);

            // act
            vm.AddCoinToJarCommand.Execute();

            // assert
            Assert.AreEqual(vm.CoinJarErrorString, ViewConstants.InvalidCoinErrorMessage);
        }

        [Test]
        public void ShouldGetErrorMessagWhenCoinJarWeightIsExceeded()
        {
            // arrange
            TestInit();
            vm.CoinJarWeight = 99999m;

            // act
            vm.AddCoinToJarCommand.Execute();

            // assert
            Assert.AreEqual(vm.CoinJarErrorString, ViewConstants.CoinWeightExceededErrorMessage);
        }

        [Test]
        public void ShouldResetJarAmount()
        {
            ResetCoinJarBaseTest();
            // assert
            Assert.AreEqual(vm.CoinJarAmount, 0.00);
        }

        [Test]
        public void ShouldResetJarWeight()
        {
            ResetCoinJarBaseTest();
            // assert
            Assert.AreEqual(vm.CoinJarWeight, 0.00);
        }

        void ResetCoinJarBaseTest()
        {
            // arrange
            TestInit();
            vm.SelectedCoin = new Coin("Nickel", ViewConstants.NickelAmount, ViewConstants.NickelWeight);

            // act
            vm.AddCoinToJarCommand.Execute();
            vm.ResetCoinJarCommand.Execute();
        }
    }
}
