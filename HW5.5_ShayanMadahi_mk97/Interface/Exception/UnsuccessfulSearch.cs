using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._5_ShayanMadahi_mk97.Interface.Exception
{
    public class UnsuccessfulSearch : ApplicationException
    {
        public override string Message => "There were no products with the entered ID!!";
    }
}
