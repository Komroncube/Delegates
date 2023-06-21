using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    public class LengthConvertor
    {
        public static void InchToMeter(double inch)
        {
            var result=inch*0.0254;
            Console.WriteLine($"{inch} inches = {result} meters");
        }
        public static void MeterToInch(double meter)
        {
            var result = meter / 0.0254;
            Console.WriteLine($"{meter} meters = {result} inches");
        }
        public static void FeetToMeter(double feet)
        {
            var result = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {result} meters");
        }
        public static void MeterToFeet(double meter)
        {
            var result = meter * 0.0254;
            Console.WriteLine($"{meter} meters = {result} feet");
        }

    }
}
