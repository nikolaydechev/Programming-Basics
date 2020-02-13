using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());

            var untreatedPatients = 0.0;
            var treatedPatients = 0.0;
            var doctors = 7;


            for (int i = 1; i <= period; i++)
            {
                var patients = int.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (untreatedPatients > treatedPatients))
                {
                    doctors++;
                }
                if (patients > doctors)
                {
                    treatedPatients = treatedPatients + doctors;
                    untreatedPatients = untreatedPatients + (patients - doctors);
                }
                else
                {
                    treatedPatients = treatedPatients + patients;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
