using System;

namespace Horoscopo
{
    class Program
    {
        static string name = "";
        static int month = 0;
        static int Main() //void
        {
            Console.WriteLine("Hola Estudiante");
            Console.Write("Digite su nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Buenas tardes, " + name);
            Console.Write("Digite su mes de nacimiento:");
            month = int.Parse(Console.ReadLine());
            //month = Convert.ToInt16((Console.ReadLine()));
            switch (month)
            {
                case 1:
                    Console.WriteLine("Eres Acuario");
                    break;

                case 2:
                    Console.WriteLine("Eres Piscis");
                    break;
                case 3:
                    Console.WriteLine("Eres Aries");
                    break;

                case 4:
                    Console.WriteLine("Eres Tauro");
                    break;
                case 5:
                    Console.WriteLine("Eres Géminis");
                    break;

                case 6:
                    Console.WriteLine("Eres Cancer");
                    break;
                case 7:
                    Console.WriteLine("Eres Leo");
                    break;

                case 8:
                    Console.WriteLine("Eres Virgo");

                    break;
                case 9:
                    Console.WriteLine("Eres Libra");
                    break;

                case 10:
                    Console.WriteLine("Eres Escorpio");
                    break;
                case 11:
                    Console.WriteLine("Eres Sagitario");
                    break;

                case 12:
                    Console.WriteLine("Eres Capricornio");
                    break;
            }

            Console.ReadKey();
            return 0;
        }
    }
}