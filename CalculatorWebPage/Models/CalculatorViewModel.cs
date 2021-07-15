using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebPage.Models
{
    public class CalculatorViewModel
    {
 
        public CalcInput LastNumber { get; set; }

        public List<CalcInput> AllNumbers { get; set; }
    }
}
