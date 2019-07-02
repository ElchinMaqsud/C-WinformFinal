using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public partial class Customer
    {
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
