using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sınav1 = 70, sınav2 = 80, sınav3 = 90;
            
            if (sınav1 < sınav2 && sınav1 < sınav3)
                Console.Write("En düşük sınav={0}", sınav1);
            else if (sınav2 < sınav1 && sınav2 < sınav3)
                Console.Write("En düşük sınav={0}", sınav2);
            else if (sınav3 < sınav1 && sınav3 < sınav2)
                Console.Write("En düşük sınav={0}", sınav3);

            Console.ReadKey();
        }
    }
}
