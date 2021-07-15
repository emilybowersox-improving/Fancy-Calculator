using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorCore;

namespace CalculatorWebPage.Models
{
    public class CalculatorViewModel
    {

        public EvaluationResult UserResult { get; set; }


        public List<EvaluationResult> DisplayedHistory { get; set; }

    }
}
