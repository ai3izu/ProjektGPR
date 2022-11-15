using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektGPR
{
    internal class Program
    {
        // klasa random gernerujaca losowe liczb
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
                Console.WriteLine("8.Mnożenie macierzy 2-wymiarowej.");
                Console.WriteLine("9.Transpozycja macierzy 3x3");
                Console.WriteLine("10.Chwila relaksu – zagraj");
                Console.WriteLine("0 -  >>Wyjdz z aplikacji<<");
                Console.WriteLine("==========================================================================");
                // konwersja zmiennej i pozwolenie na wpisanie uzytkownikowi wartosci ktory tryb chce wybrac
                wyborTrybu = Convert.ToInt32(Console.ReadLine());
                // warunki, dla kazdego wybranego trybu ( od 1 do 10) bedzie wykonywac sie cos innego
                if (wyborTrybu == 1)
                {
                    szukanieBinarne();
                }
                else if (wyborTrybu == 2)
                {
                    obliczSilnie();
                }
                else if (wyborTrybu == 3)
                {
                    sortowanieBabelkowe();
                }
                else if (wyborTrybu == 4)
                {
                    czyPalindrom();
                }
                else if (wyborTrybu == 5)
                {
                    szyfrCezara();
                }
                else if (wyborTrybu == 6)
                {
                    alrogytmONP();
                }
                else if (wyborTrybu == 7)
                {
                    minAndMax();
                }
                else if (wyborTrybu == 8)
                {
                    mnozenieMacierzy();
                }
                else if (wyborTrybu == 9)
                {
                    transpozycjaM();
                }
                else if (wyborTrybu == 10)
                {
                    chwilaRelaksu();
                }
                else if (wyborTrybu > 10)
                {
                    Console.Clear();
                    Console.WriteLine("Wybranao tryb ktory nie znajduje sie w programie");
                    Environment.Exit(0);
                }
                if (wyborTrybu != 0)
                {
                    wyborTrybu = czyKontynowac();
                    Console.Clear();
                }
            } while (wyborTrybu != 0);
        }
        // funkcja ktora pozwala uzytkownikowi kontynuowac gre lub zamknac program
        static int czyKontynowac()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("Czy chesz kontynowac gre????");
            Console.WriteLine("Nacisnij 1 aby kontynuowac albo 2 zeby przerwac gre");
            Console.WriteLine("====================================================");
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
            Console.Clear();
            Console.WriteLine("\tWybrano tryb 7 - Min i Max");
            Console.WriteLine("");
            Console.WriteLine("Podaj ile liczb chcesz wprowadzic: ");
            int liczbyUzytkownika = Convert.ToInt32(Console.ReadLine());
            int[] tablicaUzytkownika = new int[liczbyUzytkownika];
            for (int i = 0; i < tablicaUzytkownika.Length; i++)
            {
                int tmp = i + 1;
                Console.WriteLine($"Podaj {tmp} liczbe");
                tablicaUzytkownika[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maksymalnyElement = tablicaUzytkownika.Max();
            int minimalnyElement = tablicaUzytkownika.Min();
            Console.WriteLine($"Najwieksza wartosca jest {maksymalnyElement}");
            Console.WriteLine($"Najmniejsza wartosca jest {minimalnyElement}");
        }
        // funkcja sortujaca babelkowo 10 losowych liczb z przedzialu 1,50 wygenerowane funkcja random
        static void sortowanieBabelkowe()
        {
            Console.Clear();
            Console.WriteLine("\tWybrano tryb 3 - Sortowanie Babelkowe");
            Console.WriteLine("");
            Console.WriteLine("Oto twoje wylosowane liczby: ");
            int[] sortTab = new int[10];
            for (int i = 0; i < sortTab.Length; i++)
            {
                sortTab[i] = losowaLiczba.Next(1, 50);
                Console.Write($"{sortTab[i]}  ");
            }
            Console.WriteLine("");
            Console.Write("Aby posortowac liczby wpisz 1 => ");
            int czySortowac = Convert.ToInt32(Console.ReadLine());
            if (czySortowac == 1)
            {
                for (int i = 1; i < sortTab.Length; i++)
                {
                    for (int j = 1; j < sortTab.Length; j++)
                    {
                        if (sortTab[j - 1] > sortTab[j])
                        {
                            int tmp = sortTab[j - 1];
                            sortTab[j - 1] = sortTab[j];
                            sortTab[j] = tmp;
                        }
                    }
                }
                for (int i = 0; i < sortTab.Length; i++)
                {
                    Console.Write(sortTab[i] + "  ");
                }
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Blad nie wpisales wymaganej liczby");
                Environment.Exit(0);
            }
        }
        // funckja w ktorej uzytkownik wybiera przedzial, z ktorego losowana jest dla niego liczba i musi ja odgadnac 
        static void chwilaRelaksu()
        {
            Console.Clear();
            Console.WriteLine("\tWybrano tryb 10 - Czas Relaksu");
            Console.WriteLine("");
            Console.WriteLine("!!Wpisz zakres z jakiego przedzialu ma wylosowac liczbe i postaraj sie ja odgadnac!!");
            int przedzial = Convert.ToInt32(Console.ReadLine());
            int wylosowanaLiczba = losowaLiczba.Next(1, przedzial + 1);
            int liczbaWpisana = 0;
            Console.WriteLine("Sproboj zgadac liczbe :))))");
            do
            {
                liczbaWpisana = Convert.ToInt32(Console.ReadLine());
                if (liczbaWpisana > wylosowanaLiczba)
                {
                    Console.WriteLine("Sproboj mniejsza liczbe");
                }
                else if (liczbaWpisana < wylosowanaLiczba)
                {
                    Console.WriteLine("Sproboj wieksza liczbe");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Brawo zgadles liczbe!  Liczba to  {wylosowanaLiczba}");
                }
            } while (liczbaWpisana != wylosowanaLiczba);
        }
        // funkcja sprawdzajaca czy wyraz wpisany przez uzytkownika jest palindromem
        static bool czyPalindrom()
        {
            Console.Clear();
            Console.WriteLine("\t Wybrano tryb 4 - Palindromy");
            Console.WriteLine("");
            Console.WriteLine("\t ====================================================================================================");
            Console.WriteLine("\t przykladowe palindromy do sprawdzenia sos, Kamil slimak, sedes, zaraz, kajak, zakaz, owocowo, potop, radar.");
            Console.WriteLine("\t ====================================================================================================");
            Console.WriteLine("");
            Console.WriteLine("Wpisz jakis wyraz aby sprawdzic czy jest palindromem");
            string slowoUzytkownika = Console.ReadLine();
            if (String.IsNullOrEmpty(slowoUzytkownika)) { return false; }
            slowoUzytkownika = slowoUzytkownika.Replace(" ", "").ToLower();
            int dlWyrazu = slowoUzytkownika.Length;
            for (int i = 0; i < dlWyrazu  /2 ; i++)
            {
                if (slowoUzytkownika[i] != slowoUzytkownika[dlWyrazu - i - 1]) 
                {
                    Console.WriteLine($"{slowoUzytkownika} nie jest palindromem");
                    return false;
                }
            }
            Console.WriteLine($"{slowoUzytkownika} jest palindromem!!!");
            return true;
        }  
        // obliczanie silni liczby podanej przez uzytkownika
        static void obliczSilnie()
        {
            Console.Clear();
            Console.WriteLine("\tWybrano tryb 3 - Obliczanie Silni");
            Console.WriteLine("");
            Console.WriteLine("Podaj liczbe, z ktorej siline chcesz obliczyc");
            int liczbaUzytkownika = Convert.ToInt32(Console.ReadLine());
            int wynik = 1;
            for (int i = 1; i <= liczbaUzytkownika; i++)
            {
                wynik *= i;
            }         
            Console.Write($"Silnia obliczonej liczby {wynik}  ");
            Console.WriteLine(" ");
        }
        // funkcja ktora korzysta z funkcji zawierajaca algortym wyszukiwania binarnego, prosi uzytkownika o podanie ile chce liczb z danego przedzialu a nastepnie odnajduje szukana
        static void szukanieBinarne()
        {
            Console.Clear();
            Console.WriteLine("\t Wybrano tryb 1 - Szukanie binarne");
            Console.WriteLine("");
            Console.WriteLine("Podaj ile liczb chcesz wygenerowac:");
            int liczbyUzytkownik = Convert.ToInt32(Console.ReadLine());
            int[] tablicaUzytkownik = new int[liczbyUzytkownik];
            for (int i = 0; i < tablicaUzytkownik.Length; i++)
            {
                tablicaUzytkownik[i] = losowaLiczba.Next(1, 10);
            }
            Console.WriteLine("Podaj szukana liczbe");
            int szukana = Convert.ToInt32(Console.ReadLine());
            int wynikUzytkownik = szukanieBinarneAlgorytm(tablicaUzytkownik, szukana);
            if (wynikUzytkownik == -1)
            {
                Console.WriteLine("Nie znaleziono szukanej liczby");
            }
            else Console.WriteLine($"Szukana znajduje sie pod {wynikUzytkownik} indeksem");
        }
        // funkcja wykorzustujaca algortym klasyczny wyszukiwania binarnego
        static int szukanieBinarneAlgorytm(int[] tablicaLiczb, int szukana)
        {
            int lewaStrona = 0;
            int prawaStrona = tablicaLiczb.Length - 1;
            while (lewaStrona <= prawaStrona)
            {
                int obecnaPozycja = lewaStrona + (prawaStrona - lewaStrona) / 2;
                if (tablicaLiczb[obecnaPozycja] == szukana)
                {
                    return obecnaPozycja;
                }
                if (tablicaLiczb[obecnaPozycja] < szukana)
                {
                    lewaStrona = obecnaPozycja + 1;
                }
                if (tablicaLiczb[obecnaPozycja] > szukana)
                {
                    prawaStrona = obecnaPozycja - 1;
                }
            }
            return -1;
        }
        // funkcja, ktora szyfruje slowo uzytkownika wzgledem podanego klucza algorytmem szyfru cezara
        static void szyfrCezara()
        {
            Console.Clear();
            Console.WriteLine("\t Wybrales tryb 5 - szyfr Cezara");
            Console.WriteLine("Podaj jakis wyraz do zaszyfrowania");
            string slowoUzytkownika;
            var tmp = Console.ReadLine();
            if (tmp != null)
            {
                Console.WriteLine("Podaj klucz szyfrujacy");
                int kluczSzyfrowania = Convert.ToInt32(Console.ReadLine());
                String szyfr = "";
                slowoUzytkownika = tmp;
                for (int i = 0; i < slowoUzytkownika.Length; i++)
                {
                    if (Char.IsUpper(slowoUzytkownika[i]))
                    {
                        int indeksZnaku = slowoUzytkownika[i] - (char)('A');
                        int przesuniecieZnaku = (indeksZnaku + kluczSzyfrowania) % 26 + (char)('a');
                        szyfr += (char)(przesuniecieZnaku);
                    }
                    else if (Char.IsLower(slowoUzytkownika[i]))
                    {
                        int indeksZnaku = slowoUzytkownika[i] - (char)('a');
                        int przesuniecieZnaku = (indeksZnaku + kluczSzyfrowania) % 26 + (char)('a');
                        szyfr += (char)(przesuniecieZnaku);
                    }
                    else if (Char.IsDigit(slowoUzytkownika[i]))
                    {
                        int nowyZnak = (int)(slowoUzytkownika[i] + kluczSzyfrowania) % 10;
                        szyfr += (char)(nowyZnak);
                    }
                    else { szyfr += slowoUzytkownika[i]; }
                }           
                Console.WriteLine("");
                Console.WriteLine($"Podales klucz {kluczSzyfrowania}  wedlug tego klucza slowo ktore zaszyfrowales to {szyfr}");            
            }
        }
        //onp start
        // funkcja sprawdzajaca czy wpisany znak jest operatorem matematycznym
        static bool czyOperator(char znak)
        {
            return znak == '+' || znak == '-' || znak == '*' || znak == '/';
        }
        // funkcja sprawdzajaca czy wpisany znak jest cyfra
        static bool czyCyfra(char znak)
        {
            return znak >= '0' && znak <= '9';
        }
        // funkcja zamieniajaca string na int 
        static int stringNaInt(string a, int liczba)
        {
            int tmp = 0;
            while (liczba < a.Length && czyCyfra(a[liczba]))
            {
                tmp = tmp * 10 + a[liczba] - '0';
                ++liczba;
            }
            --liczba;
            return tmp;
        }
        // funkcja okreslajaca dzialania matematyczne
        static int dzialania(int liczba1, int liczba2, char oper)
        {
            switch (oper)
            {
                case '-':
                    return liczba1 - liczba2;
                case '+':
                    return liczba1 + liczba2;
                case '*': 
                    return liczba1 * liczba2;
                case '/':
                    return liczba1 / liczba2;
            }
            Console.WriteLine("Podano nieprawidlowy operator");
            return 0;
        }
        // algortym onp dziala on z wykorzystaniem powyzszych 4 funkcji, uzytkownik podaje wyrazenie zapisane w ONP i otrzymuje on wynik wyrazenia
        static void alrogytmONP()
        {         
            Console.Clear();
            Console.WriteLine("\t Wybrano tryb 6 - ONP");
            Console.WriteLine("Podaj wyrazenie w ONP");
            string onp = Console.ReadLine();
            Stack<int> stos = new Stack<int>();
            int liczbaUzytk1, liczbaUzytk2;
            for (int i = 0; i < onp.Length; i++)
            {
                if (czyCyfra(onp[i]))
                {                   
                    stos.Push((stringNaInt(onp, i)));
                }             
                else 
                {
                    if (czyOperator(onp[i]))
                    {                    
                        liczbaUzytk1 = stos.Peek();
                        stos.Pop();
                        liczbaUzytk2 = stos.Peek();
                        stos.Pop();
                        stos.Push(dzialania(liczbaUzytk2, liczbaUzytk1, onp[i]));
                    }
                }                         
            }
            if (stos.Count() < 1) 
            {
                Console.WriteLine("Niepoprawne wyrażenie ONP");
            }
            else
            {
                Console.WriteLine($"Wynik twojego dzialania {onp} to: {stos.Peek()}");
            }           
        }
        //onp koniec
        // mnozenie macierzy uzytkownik podaje ilosc wierzszy i kolumn dla 2 maciezy nastepnie sa wypelniane wartosciami losowymi i mnozone
        static void mnozenieMacierzy()
        {
            Console.Clear();          
            // utworzenie zmiennych a b to pierwsza macierz x y to druga
            int a, b;
            int x, y;
            int[,] macierz1;
            int[,] macierz2;
            do
            {
                try
                {
                    Console.WriteLine("\tWybrano tryb 8 - Mnożenie macierzy 2-wymiarowej.");
                    Console.Write("Podaj ilosc wierszy pierwszej macierzy: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj ilosc kolumn pierwszej macierzy: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    macierz1 = new int[a, b];
                    Console.Clear();
                    Console.WriteLine("\tWybrano tryb 8 - Mnożenie macierzy 2-wymiarowej.");
                    Console.Write("Podaj ilosc wierszy drugiej macierzy: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj ilosc kolumn drugiej macierzy: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    macierz2 = new int[x, y];
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\t Ujemna wartosc - sproboj ponownie");
                    Thread.Sleep(800);
                    Console.Clear();
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("\t Wartosc inna niz przewidywana - sprobuj ponownie");
                    Thread.Sleep(800);
                    Console.Clear();
                    continue;
                }
                break;
            } while (true);
            Console.Clear();
            // losowanie liczb do macierzy 1 
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b   ; j++)
                {
                    macierz1[i, j] = losowaLiczba.Next(1, 11);
                }
            }
            Console.WriteLine("\tPierwsza macierz: ");
            Console.WriteLine("=========================");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{macierz1[i, j]}\t");
                }               
                Console.Write("\n");
            }
            Console.WriteLine("=========================");
            // losowanie liczb do macierzy 2
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    macierz2[i, j] = losowaLiczba.Next(1, 11);
                }
            }
            Console.WriteLine("\tDruga macierz: ");
            Console.WriteLine("=========================");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{macierz2[i, j]}\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("=========================");

            Console.WriteLine("\tSprawdzanie macierzy");
            if(b != x)
            {
                Console.WriteLine("Mnozenie jest niemozliwe");
            }
            else
            {
                int[,] macierzWynik = new int[a, x];
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        macierzWynik[i, j] = 0;
                        for (int k = 0; k < b; k++)
                        {
                            macierzWynik[i, j] += macierz1[i, k] * macierz2[k, j];
                        }
                    }
                }
                Console.WriteLine("\tMnozenie maciezy....");
                Thread.Sleep(1000);
                Console.WriteLine("\tWynik pomnozonych maciezy");
                Console.WriteLine("=======================");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write($"{macierzWynik[i,j]}\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("=======================");
            }
        }
        // funckja transpozycji maciezy losuje liczby z zakresu 1 50 do tablicy i wykonuje ich transpozycje
        static void transpozycjaM()
        {
            Console.Clear();
            Console.WriteLine("\tWybrano tryb 9 - Transpozycja Maciezy 3 x 3");
            int[,] tabMaciez = new int[3, 3];
            int[,] tabTrans = new int[3, 3];
            Console.WriteLine("Liczby wylosowane do tablicy 3x3");
            Console.WriteLine("==================================");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabMaciez[i, j] = losowaLiczba.Next(1, 50);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{tabMaciez[i,j]}\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("==================================");
            Console.WriteLine("\tTranspozycja Maciezy");
            Thread.Sleep(1000);
            Console.WriteLine("==================================");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabTrans[j, i] = tabMaciez[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{tabTrans[i,j]}\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("==================================");
        }
    }   
}
