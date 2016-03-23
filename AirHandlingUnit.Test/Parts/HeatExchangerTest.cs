using System;
using System.Collections.Generic;
using AirHandlingUnit.Parts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirHandlingUnits;
using AirHandlingUnits.Parts;

namespace AirHandlingUnits.Test
{
    [TestClass]
    public class HeatExchangerTest
    {
        private Fan AddNewFan()
        {
            var partslist = new List<Object> { "My Fan", Fan.FanTypes.Box };
            return (Fan)PartFactory<Fan>.Instance.GetCustomPart(partslist);
        }
        private HeatExchanger AddNewHeatExchanger()
        {
            var partslist = new List<Object> { "My Really Powerful Heat Exchanger", 1000, HeatExchanger.HeatExchangerTypes.Tube };
            return (HeatExchanger) PartFactory<HeatExchanger>.Instance.GetCustomPart(partslist);
        }

        private Filter AddNewFilter()
        {
            var partslist = new List<Object> { "My Filter", 100 };
            return (Filter)PartFactory<Filter>.Instance.GetCustomPart(partslist);
        }

        [TestMethod]
        public void TestGetAllCustomParts_HeatExchanger_Method()
        {
            var exchanger = AddNewHeatExchanger();
            var all = PartFactory<HeatExchanger>.Instance.GetAllCustomParts();

            Assert.IsNotNull(exchanger);
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Parts.Contains(exchanger));
        }

        [TestMethod]
        public void TestGetCustomPart_HeatExchanger_Method()
        {
            var exchanger = AddNewHeatExchanger();
            Assert.IsNotNull(exchanger);
        }

        [TestMethod]
        public void TestGetAllCustomParts_Fan_Method()
        {
            var fan = AddNewFan();
            var all = PartFactory<Fan>.Instance.GetAllCustomParts();

            Assert.IsNotNull(fan);
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Parts.Contains(fan));
        }

        [TestMethod]
        public void TestGetAllCustomParts_Filter_Method()
        {
            var filter = AddNewFilter();
            var all = PartFactory<Filter>.Instance.GetAllCustomParts();

            Assert.IsNotNull(filter);
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Parts.Contains(filter));
        }

        //[TestMethod]
        //public void TestGetCustomHeatExchangerMethodEqualObjects()
        //{
        //    var exchanger1 = HeatExchangerFactory.GetInstance().GetCustomHeatExchanger(desc: "My Really Powerful Heat Exchanger", power: 1000, type: HeatExchanger.HeatExchangerTypes.Tube);
        //    var exchanger2 = HeatExchangerFactory.GetInstance().GetCustomHeatExchanger(desc: "My Really Powerful Heat Exchanger", power: 1000, type: HeatExchanger.HeatExchangerTypes.Tube);

        //    Assert.IsNotNull(exchanger1);
        //    Assert.IsNotNull(exchanger2);
        //    Assert.IsTrue(exchanger1 == exchanger2);
        //}

        //[TestMethod]
        //public void TestGetCustomHeatExchangerMethodNotEqualObjects()
        //{
        //    var exchanger1 = HeatExchangerFactory.GetInstance().GetCustomHeatExchanger(desc: "My Really Powerful Heat Exchanger", power: 1000, type: HeatExchanger.HeatExchangerTypes.Tube);
        //    var exchanger2 = HeatExchangerFactory.GetInstance().GetCustomHeatExchanger(desc: "My Really Powerful Heat Exchanger", power: 1001, type: HeatExchanger.HeatExchangerTypes.Tube);

        //    Assert.IsNotNull(exchanger1);
        //    Assert.IsNotNull(exchanger2);
        //    Assert.IsFalse(exchanger1 == exchanger2);

        //}
    }
}
