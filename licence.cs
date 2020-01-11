using System;

namespace wypov1
{
    class licence
    {
        public static void DisplayLicence()
        {
            int day = 15;
            bool t = true;
            while (t)
            {
                Console.WriteLine("Wybierz jaką opcję chcesz wybrać: ");

                Console.WriteLine("[1] Przedłóż licencję");
                Console.WriteLine("[2] Ile dni pozostało do końca licencji");

                Console.WriteLine("[0] Wyjście");

                int i;
                int.TryParse(Console.ReadLine(), out i);



                if (i == 1)
                {
                    Console.Clear();
                    Console.WriteLine(day + 365);
                    Console.WriteLine("Licencja została przedłóżona");
                    Console.ReadKey();
                    t = false;
                }
               else if (i == 2)
                {
                    Console.Clear();

                    Console.WriteLine("Do końca licencji zostało "+day);
                    Console.ReadKey();
                    t = false;
                }
               else if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Koniec");
                    t = false;
                }
            }
        }
    }
}
