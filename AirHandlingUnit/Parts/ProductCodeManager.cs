namespace AirHandlingUnit.Parts
{
    public class ProductCodeManager
    {
        private int _lastUsedProductCode = 0;
        private readonly string _productCodePrefix;

        public ProductCodeManager(string prefix)
        {
            _productCodePrefix = prefix;
        }

        /// <summary>
        /// Get the next available Product Code value for the given product code prefix
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public string GetNewProductCode()
        {
            return _productCodePrefix + _lastUsedProductCode++;
        }
    }
}
