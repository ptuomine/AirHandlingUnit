using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirHandlingUnit;

namespace AirHandlingUnit.Test
{
    [TestClass]
    public class HeatExchangerTest
    {
        [TestMethod]
        public void TestGetCustomHeatExchangerMethod()
        {
            var exchanger = HeatExchanger.GetCustomHeatExchanger("My Really Powerful Heat Exchanger", 1000, HeatExchanger.HeatExchangerTypes.Tube);

            Assert.IsNotNull(exchanger);
        }

        [TestMethod]
        public void TestGetCustomHeatExchangerMethodEqualObjects()
        {
            var exchanger1 = HeatExchanger.GetCustomHeatExchanger("My Really Powerful Heat Exchanger", 1000, HeatExchanger.HeatExchangerTypes.Tube);
            var exchanger2 = HeatExchanger.GetCustomHeatExchanger("My Really Powerful Heat Exchanger", 1000, HeatExchanger.HeatExchangerTypes.Tube);

            Assert.IsNotNull(exchanger1);
            Assert.IsNotNull(exchanger2);
            Assert.IsTrue(exchanger1 == exchanger2);

        }

        [TestMethod]
        public void TestGetCustomHeatExchangerMethodNotEqualObjects()
        {
            var exchanger1 = HeatExchanger.GetCustomHeatExchanger("My Really Powerful Heat Exchanger", 1000, HeatExchanger.HeatExchangerTypes.Tube);
            var exchanger2 = HeatExchanger.GetCustomHeatExchanger("My Really Powerful Heat Exchanger", 1001, HeatExchanger.HeatExchangerTypes.Tube);

            Assert.IsNotNull(exchanger1);
            Assert.IsNotNull(exchanger2);
            Assert.IsFalse(exchanger1 == exchanger2);

        }
    }
}
