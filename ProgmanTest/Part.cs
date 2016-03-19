using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnit
{
    public abstract class Part
    {
        public Part(string pc, string desc)
        {
            this.ProductCode = pc;
            this.Description = desc;
        }

        public string ProductCode { get; set; }
        public string Description { get; set; }

        public virtual void PrintToConsole()
        {
            Console.WriteLine("Product Code: " + ProductCode);
            Console.WriteLine("Description: " + Description);
        }
    }
}