using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaWeightCalculator
{
    public class weightcalculator
    {
        public double height {  get; set; }
        public char gender { get; set; }
        public double GetIdealWeight()
        {
            switch (gender)
            {
                case 'm':
                    return (height - 100) - ((height - 150) / 4);
                case 'w':
                    return (height - 100) - ((height - 150) / 2);
                default:
                    return 0;

            }
        }
    }
}
