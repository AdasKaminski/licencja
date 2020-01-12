using System;

namespace wypov1
{
    class licence
    {
        public static void DisplayLicence()
        {
            DateTime date = DateTime.Now.Date;
            DateTime date1 = DateTime.Parse("17-01-2020");
           
            bool t = true;
            while (t)
            {
                Console.WriteLine("Wybierz jaką opcję chcesz wybrać: ");
                Console.WriteLine();
                Console.WriteLine("Do końca twojej licencji zostało:");
                Console.WriteLine(date1-date);
                Console.WriteLine("[1] Przedłóż licencję");
                

                Console.WriteLine("[0] Wyjście");

                int i;
                int.TryParse(Console.ReadLine(), out i);



                if (i == 1)
                {
                    Console.Clear();
                   Console.WriteLine(DateTime.Now.AddDays(365));
                  Console.WriteLine("Licencja została przedłóżona");
                 Console.ReadKey();
                   t = false;
                }
              
               else if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Koniec");
                    t = false;
                }
                else
                {
                    Console.WriteLine("Wybrałeś nie poprawną opcję");
                }
            }
        }
    }
}
