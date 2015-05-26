using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDrinkOrderSystem
{
    class COrder
    {
        public string name { get; set; }
        public string size { get; set; }
        public string sugar { get; set; }
        public string ice { get; set; }
        public int count { get; set; }
        public int unitPrice { get; set; }
        public int totalPrice { get; set; }
    }
}
