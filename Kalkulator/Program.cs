using System;

namespace Kalkulator
{
    public class Program
    {
        public static bool działanie = true;
        static void Main(string[] args)
        {

            do
            {

                Funkcje funkcje = new Funkcje();

                funkcje.Menu();

            } while (działanie != false);

        }
    }
    public class Funkcje
    {

        private double a;
        private double b;
        private double wynik;
        private int decyzja;

        public void Menu()
        {
            Console.WriteLine("1. Dodawanie \n2. Odejmowanie \n3. Mnożenie \n4. Dzielenie \n5. Potęgowanie \n0. Wyjście\n");

            decyzja = Convert.ToInt16(Console.ReadLine());

            switch (decyzja)
            {
                case 1:

                    dane();

                    dodawanie();

                    Console.WriteLine("\nWynik dodawania wynosi: {0}\n", wynik);

                    break;

                case 2:

                    dane();

                    odejmowanie();

                    Console.WriteLine("\nWynik odejmowania wynosi: {0}\n", wynik);

                    break;

                case 3:

                    dane();

                    mnożenie();

                    Console.WriteLine("\nWynik mnożenia wynosi: {0}\n", wynik);

                    break;

                case 4:

                    dane();

                    dzielenie();

                    Console.WriteLine("\nWynik dzielenia wynosi: {0}\n", wynik);

                    break;

                case 5:

                    dane();

                    potęgowanie();

                    Console.WriteLine("\nWynik potęgowania wynosi: {0}\n", wynik);

                    break;

                case 0:

                    Program.działanie = false;

                    break;

                default:

                    Console.WriteLine("Należy wybrać jedną z podanych opcji");

                    break;
            }
        }

        public void dane()
        {

            Console.WriteLine("\nWprowadź pierwszą liczbę: ");

            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWprowadź drugą liczbę: ");

            b = Convert.ToInt32(Console.ReadLine());

        }

        public double dodawanie()
        {
            wynik = a + b;

            return wynik;
        }
        public double odejmowanie()
        {
            wynik = a - b;

            return wynik;
        }
        public double mnożenie()
        {
            wynik = a * b;

            return wynik;
        }
        public double dzielenie()
        {
            wynik = a / b;

            return wynik;
        }
        public double potęgowanie()
        {
            wynik = a;

            for (int i = 0; i < b - 1; i++)
            {

                wynik *= a;

            }

            return wynik;

        }
    }
}