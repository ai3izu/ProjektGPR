using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjektGPR
{
    internal class Program
    {
        // klasa random gernerujaca losowe liczby dla trybu nr 10
        static Random losowaLiczba = new Random();
        static void Main(string[] args)
        {   
            // zmiena definujaca wybor trybu przez uzytkownika
            int wyborTrybu; 
            do
            {
                Console.WriteLine("\tProjektGRP - wpisz liczbe od 1 - 10 aby wybrac tryb");
                Console.WriteLine("==========================================================================");
                Console.WriteLine("1.Przeszukiwanie binarne – wersja iteracyjna");
                Console.WriteLine("2.Obliczanie silni liczby naturalnej");
                Console.WriteLine("3.Sortowanie: bąbelkowe ");
                Console.WriteLine("4.Sprawdzanie czy wyraz jest Palindromem");
                Console.WriteLine("5.Szyfrowanie – szyfr Cezara");
                Console.WriteLine("6.Wyznaczanie wartości wyrażenia zapisanego w odwrotnej notacji polskiej ONP");
                Console.WriteLine("7.Jednoczesne znajdowanie minimalnego i maksymalnego elementu.");
                Console.WriteLine("8.Mnożenie macierzy 2-wymiarowej.  ");
                Console.WriteLine("9.Transpozycja macierzy 3x3");
                Console.WriteLine("10.Chwila relaksu – zagraj");
                Console.WriteLine("0 -  >>Wyjdz z aplikacji<<");
                Console.WriteLine("==========================================================================");
                // konwersja zmiennej i pozwolenie na wpisanie uzytkownikowi wartosci ktory tryb chce wybrac
                wyborTrybu = Convert.ToInt32(Console.ReadLine());
                // warunki, dla kazdego wybranego trybu ( od 1 do 10) bedzie wykonywac sie cos innego
                if (wyborTrybu == 1)
                {
                    
                }
                else if (wyborTrybu == 2)
                {

                }
                else if  (wyborTrybu == 3)
                {

                }
                else if (wyborTrybu == 4)
                {

                }
                else if (wyborTrybu == 5)
                {

                }
                else if (wyborTrybu == 6)
                {

                }
                else if (wyborTrybu == 7)
                {

                }
                else if (wyborTrybu == 8)
                {

                }
                else if (wyborTrybu == 9)
                {

                }
                else if (wyborTrybu == 10)
                {
                    
                }
                if (wyborTrybu != 0)
                {
                    Console.Clear();
                    wyborTrybu = czyKontynowac();
                    Console.Clear();
                }
            } while (wyborTrybu != 0);
        }
        // funkcja ktora pozwala uzytkownikowi kontynuowac gre lub zamknac program
       static int czyKontynowac()
        {
            Console.WriteLine("\t====================================================");
            Console.WriteLine("\t Czy chesz kontynowac gre????");
            Console.WriteLine("\t Nacisnij 1 aby kontynuowac albo 2 zeby przerwac gre");
            Console.WriteLine("\t====================================================");
            int wybor = Convert.ToInt32(Console.ReadLine());
            if (wybor == 1)
            {
                 return 1;
            }
            else return 0;
        }
        // funkcja odnajdujaca minimalny i maksymalny element z tablicy liczb podanych przez uzytkownika
       static void minAndMax()
        {

        }
    }
}
