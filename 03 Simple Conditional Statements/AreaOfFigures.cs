using System;

namespace Area_of_Figures
{
    class AreaOfFigures
    {
        public static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            var size1 = double.Parse(Console.ReadLine());
            
            var area = 0.0;
            if (figure == "square")
            {
                area = size1 * size1;
                Console.WriteLine(area);
            }
            else if (figure =="rectangle")
            {
                var size2 = double.Parse(Console.ReadLine());
                area = size1 * size2;
                Console.WriteLine(area);
            }
            else if (figure == "circle")
            {
                area = Math.PI * size1 * size1;
                Console.WriteLine(area);
            }
            else if (figure == "triangle")
            {
                var size2 = double.Parse(Console.ReadLine());
                area = (size1 * size2) / 2;
                Console.WriteLine(area);
            }
            
        }
    }
}
