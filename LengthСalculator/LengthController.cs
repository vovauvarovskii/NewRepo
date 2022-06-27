using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthСalculator
{
    internal class LengthController
    {
        public List<string> LengthUnit { get; set; } = new List<string>()
        {
             "метр" , "километр" , "сантиметр" , "миллиметр"
        };

        internal object MetematicCalc(string inUint, string outUint, double valueLength)
        {
             if (string.Compare(inUint, outUint) == 0)
                return valueLength;

            if (inUint == "метр" && outUint == "километр") 
                return valueLength / (double) 1000;

            if (inUint == "метр" && outUint == "сантиметр") 
                return valueLength * 100;


            if (inUint == "метр" && outUint == "миллиметр") 
                return valueLength  * (double)1000;


            if (inUint == "километр" && outUint == "метр") 
                return valueLength * (double)1000;



            if (inUint == "километр" && outUint == "сантиметр") 
                return valueLength * (double)1000 * 100;


            if (inUint == "километр" && outUint == "миллиметр") 
                return valueLength * (double)1000 * 100 *100;

            if (inUint == "сантиметр" && outUint == "миллиметр") 
                return valueLength *10;

            return -1;

        }
    }


}
