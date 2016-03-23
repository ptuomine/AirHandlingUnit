using System;
using System.Collections.Generic;
using AirHandlingUnits;
using AirHandlingUnits.Parts;

namespace AirHandlingUnit.Parts
{
    public class ProductCodeManager<T> where T:Part
    {
        private int _lastUsedProductCode = 0;
        private readonly string _productCodePrefix;

        private readonly Dictionary<Type, string> _prefixes = new Dictionary<Type, string>
        {
            { typeof(Fan), "Fan" },
            { typeof(Filter), "FIL" },
            { typeof(Coil), "COI" },
            { typeof(HeatExchanger), "HE" },
            { typeof(Battery), "BAT" }
        };

        public ProductCodeManager()
        {
            var parttype = typeof (T);
            _prefixes.TryGetValue(parttype, out _productCodePrefix);
        }

        /// <summary>
        /// Get the next available Product Code value
        /// </summary>
        /// <returns></returns>
        public string GetNewProductCode()
        {
            return _productCodePrefix + _lastUsedProductCode++;
        }
    }
}
