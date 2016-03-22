using System;
using System.Collections.Generic;
using System.Linq;
using AirHandlingUnits.Parts;

namespace AirHandlingUnit.Parts
{
    public class PartFactory<T>
    {
        //private static PartFactory<T> _instance;
        private readonly ProductCodeManager _productCodeFactoryInstance;
        private readonly Dictionary<string, Part> _parts = new Dictionary<string, Part>();
        private readonly Type _parttype;

        public PartFactory(string prefix)
        {
            _parttype = typeof(T);
            this._productCodeFactoryInstance = new ProductCodeManager(prefix: prefix);
        } 

        //public static PartFactory<T> GetInstance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new PartFactory<T>();
        //    }

        //    return _instance;
        //}

        public Part GetCustomPart(List<object> properties)
        {
            // First try to find an instance with the given specifications
            //var found = _parts.Values.Where(he => he.Description == desc && he.Power == power && he.HeatExchangerType == type).FirstOrDefault();
            //if (found != null)
            //{
            //    return found;
            //}

            // If not found then create one
            var pc = _productCodeFactoryInstance.GetNewProductCode();

            properties.Insert(0, pc);
            var typename = _parttype.ToString();

            var instance = (Part) System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(
                typeName: typename, // string including namespace of the type
                ignoreCase: false,
                bindingAttr: System.Reflection.BindingFlags.Default,
                binder: null,  // use default binder
                args: properties.ToArray(),
                culture: null, // use CultureInfo from current thread
                activationAttributes: null
            );

            _parts.Add(pc, instance);

            return instance;

            // First try to find an instance with the given specifications
            //var found = customHeatExchangers.Values.Where(he => he.Description == desc && he.Power == power && he.HeatExchangerType == type).FirstOrDefault();
            //if (found != null)
            //{
            //    return found;
            //}

            // If not found then create one
            //var pc = productCodeFactoryInstance.GetNewProductCode();
            //var customHeatExchanger = new HeatExchanger(pc, desc, power, type);
            //customHeatExchangers.Add(pc, customHeatExchanger);

            //return customHeatExchanger;
        }

        public PartCollection GetAllCustomParts()
        {
            return new PartCollection(_parts.Values.ToList());
        }
    }
}