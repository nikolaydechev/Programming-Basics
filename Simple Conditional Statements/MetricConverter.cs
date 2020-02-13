using System;

namespace MetricConverter
{
    class MetricConverter
    {
        public static void Main(string[] args)
        {
            var numInput = double.Parse(Console.ReadLine());
            string InMetric = Console.ReadLine();
            string OutMetric = Console.ReadLine();

            double result = 00;

            if (InMetric == "km")
            {
                if (OutMetric == "km")
                {
                    result = numInput;
                }
                if (OutMetric == "m")
                {
                    result = numInput * 1000;
                }
                if (OutMetric == "cm")
                {
                    result = numInput * 100000;
                }
                if (OutMetric == "mi")
                {
                    result = numInput * 0.621371;
                }
                if (OutMetric == "mm")
                {
                    result = numInput * 1000000;
                }
                if (OutMetric == "ft")
                {
                    result = numInput * 3280.84;
                }
                if (OutMetric == "yd")
                {
                    result = numInput * 1093.61;
                }
                if (OutMetric == "in")
                {
                    result = numInput * 39370.1;
                }
            }
            else if (InMetric == "mm")
            {
                if (OutMetric == "km")
                {
                    result = numInput * 1e-6;
                }
                if (OutMetric == "m")
                {
                    result = numInput * 0.001;
                }
                if (OutMetric == "cm")
                {
                    result = numInput * 0.1;
                }
                if (OutMetric == "mi")
                {
                    result = numInput * 6.21371e-7;
                }
                if (OutMetric == "mm")
                {
                    result = numInput;
                }
                if (OutMetric == "ft")
                {
                    result = numInput * 0.00328084;
                }
                if (OutMetric == "yd")
                {
                    result = numInput * 0.00109361;
                }
                if (OutMetric == "in")
                {
                    result = numInput * 0.0393701;
                }
            }
            else if (InMetric == "cm")
            {
                if (OutMetric == "km")
                {
                    result = numInput * 1e-5;
                }
                if (OutMetric == "m")
                {
                    result = numInput * 0.01;
                }
                if (OutMetric == "cm")
                {
                    result = numInput;
                }
                if (OutMetric == "mi")
                {
                    result = numInput * 6.21371e-6;
                }
                if (OutMetric == "mm")
                {
                    result = numInput * 10;
                }
                if (OutMetric == "ft")
                {
                    result = numInput * 0.0328084;
                }
                if (OutMetric == "yd")
                {
                    result = numInput * 0.0109361;
                }
                if (OutMetric == "in")
                {
                    result = numInput * 0.393701;
                }

            }
            else if (InMetric == "mi")
            {
                if (OutMetric == "km")
                {
                    result = numInput * 1.60934;
                }
                if (OutMetric == "m")
                {
                    result = numInput * 1609.34;
                }
                if (OutMetric == "cm")
                {
                    result = numInput * 160934;
                }
                if (OutMetric == "mi")
                {
                    result = numInput;
                }
                if (OutMetric == "mm")
                {
                    result = numInput * 1.609e+6;
                }
                if (OutMetric == "ft")
                {
                    result = numInput * 5280;
                }
                if (OutMetric == "yd")
                {
                    result = numInput * 1760;
                }
                if (OutMetric == "in")
                {
                    result = numInput * 63360;
                }
            }
            else if (InMetric == "in")
            {
                if (OutMetric == "km")
                {
                    result = numInput * 2.54e-5;
                }
                if (OutMetric == "m")
                {
                    result = numInput * 0.0254;
                }
                if (OutMetric == "cm")
                {
                    result = numInput * 2.54;
                }
                if (OutMetric == "mi")
                {
                    result = numInput * 1.57828e-5;
                }
                if (OutMetric == "mm")
                {
                    result = numInput * 25.4;
                }
                if (OutMetric == "ft")
                {
                    result = numInput * 0.0833333;
                }
                if (OutMetric == "yd")
                {
                    result = numInput * 0.0277778;
                }
                if (OutMetric == "in")
                {
                    result = numInput;
                }
            }
            else if (InMetric == "ft")
            {
                if (OutMetric == "km")
                {
                    result = numInput * 0.0003048;
                }
                if (OutMetric == "m")
                {
                    result = numInput * 0.3048;
                }
                if (OutMetric == "cm")
                {
                    result = numInput * 30.48;
                }
                if (OutMetric == "mi")
                {
                    result = numInput * 0.000189394;
                }
                if (OutMetric == "mm")
                {
                    result = numInput * 304.8;
                }
                if (OutMetric == "ft")
                {
                    result = numInput;
                }
                if (OutMetric == "yd")
                {
                    result = numInput * 0.333333;
                }
                if (OutMetric == "in")
                {
                    result = numInput * 12;
                }
            }
           
            else if (InMetric == "yd")
            {
                if (OutMetric == "km")
                {
                    result = numInput * 0.0009144;
                }
                if (OutMetric == "m")
                {
                    result = numInput * 0.9144;
                }
                if (OutMetric == "cm")
                {
                    result = numInput * 91.44;
                }
                if (OutMetric == "mi")
                {
                    result = numInput * 0.000568182;
                }
                if (OutMetric == "mm")
                {
                    result = numInput * 914.4;
                }
                if (OutMetric == "ft")
                {
                    result = numInput;
                }
                if (OutMetric == "yd")
                {
                    result = numInput * 3;
                }
                if (OutMetric == "in")
                {
                    result = numInput * 36;
                }
            }
            Console.WriteLine(result);

            

        }
    }
}
