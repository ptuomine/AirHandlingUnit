using System;
using System.Collections.Generic;
using System.Linq;
using AirHandlingUnits.Parts;

namespace AirHandlingUnit.Parts
{
    public class PartFactory<T> where T:Part, new()
    {
        // The two below declarations are for the generic singleton using Lazy creation of the instance
        private static readonly Lazy<PartFactory<T>> instance = new Lazy<PartFactory<T>>(()=>new PartFactory<T>());
        public static PartFactory<T> Instance { get { return instance.Value; } }

        private readonly ProductCodeManager<T> _productCodeFactoryInstance;
        private readonly Dictionary<string, Part> _parts = new Dictionary<string, Part>();
        private readonly Type _parttype;

        PartFactory()
        {
            _parttype = typeof(T);
            this._productCodeFactoryInstance = new ProductCodeManager<T>();
        }

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

            var customPart = (Part) System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(
                typeName: typename, // string including namespace of the type
                ignoreCase: false,
                bindingAttr: System.Reflection.BindingFlags.Default,
                binder: null,  // use default binder
                args: properties.ToArray(),
                culture: null, // use CultureInfo from current thread
                activationAttributes: null
            );

            _parts.Add(pc, customPart);

            return customPart;
        }

        public PartCollection GetAllCustomParts()
        {
            return new PartCollection(_parts.Values.ToList());
        }
    }
}