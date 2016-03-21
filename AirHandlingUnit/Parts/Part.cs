using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits.Parts
{
    [DataContract]
    public class Part
    {
        public Part()
        {
        }

        public Part(string pc, string desc)
        {
            this.ProductCode = pc;
            this.Description = desc;
        }

        [DataMember]
        public string ProductCode { get; set; }
        [DataMember]
        public string Description { get; set; }

        public virtual void PrintToConsole()
        {
            Console.WriteLine("Product Code: " + ProductCode);
            Console.WriteLine("Description: " + Description);
        }
    }
}