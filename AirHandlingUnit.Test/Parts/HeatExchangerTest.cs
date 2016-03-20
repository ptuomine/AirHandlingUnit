using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirHandlingUnits;

namespace AirHandlingUnits.Test
{
    [TestClass]
    public class HeatExchangerTest
    {
        [TestMethod]
        public void TestGetCustomHeatExchangerMethod()
        {
            var exchanger = HeatExchangerFactory.GetInstance().GetCustomHeatExchanger(desc: "My Really Powerful Heat Exchanger", power: 1000, type: HeatExchanger.HeatExchangerTypes.Tube);

            Assert.IsNotNull(exchanger);
        }

        [TestMethod]
        public void TestGetCustomHeatExchangerMethodEqualObjects()
        {
            var exchanger1 = HeatExchangerFactory.GetInstance().GetCustomHeatExchanger(desc: "My Really Powerful Heat Exchanger", power: 1000, type: HeatExchanger.HeatExchangerTypes.Tube);
            var exchanger2 = HeatExchangerFactory.GetInstance().GetCustomHeatExchanger(desc: "My Really Powerful Heat Exchanger", power: 1000, type: HeatExchanger.HeatExchangerTypes.Tube);

            Assert.IsNotNull(exchanger1);
            Assert.IsNotNull(exchanger2);
            Assert.IsTrue(exchanger1 == exchanger2);
        }

        [TestMethod]
        public void TestGetCustomHeatExchangerMethodNotEqualObjects()
        {
            var exchanger1 = HeatExchangerFactory.GetInstance().GetCustomHeatExchanger(desc: "My Really Powerful Heat Exchanger", power: 1000, type: HeatExchanger.HeatExchangerTypes.Tube);
            var exchanger2 = HeatExchangerFactory.GetInstance().GetCustomHeatExchanger(desc: "My Really Powerful Heat Exchanger", power: 1001, type: HeatExchanger.HeatExchangerTypes.Tube);

            Assert.IsNotNull(exchanger1);
            Assert.IsNotNull(exchanger2);
            Assert.IsFalse(exchanger1 == exchanger2);

        }
    }
}
