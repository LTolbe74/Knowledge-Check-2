using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Knowledge_Check_2
{
    internal class Shoe : AthleticStore
    {
        public string Color {  get; set; }
        public int Size { get; set; }

        
        public override string ToString()
        {
            return "We are processing your order for a size "  + Size + " " + Color + " " + Name + " at a total price of " + Quantity * Price + " dollars." ;
        }

    }
   
}
