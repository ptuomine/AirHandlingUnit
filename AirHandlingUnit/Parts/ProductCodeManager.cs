using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnit.Parts
{
    public class ProductCodeManager
    {
        private int lastUsedProductCode = 0;
        private readonly string productCodePrefix;
        public ProductCodeManager(string prefix)
        {
            this.productCodePrefix = prefix;
        }

        /// <summary>
        /// Get the next available Product Code value for the given product code prefix
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public string GetNewProductCode()
        {
            return productCodePrefix + lastUsedProductCode++;
        }
    }
}
