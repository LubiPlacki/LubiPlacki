using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("podaj PESEL:");
        string pesel = Console.ReadLine();

        if (IsPeselValid(pesel))
        {
            string gender = GetGender(pesel);
            Console.WriteLine("PESEL poprawny. plec:");
            if(gender=="M"){
               Console.WriteLine("Mezczyzna"); 
            }
            else{
                Console.WriteLine("Kobieta");
            }
        }
        else
        {
            Console.WriteLine("PESEL nie poprawny");
        }
    }

    static bool IsPeselValid(string pesel)
    {
        if (pesel.Length != 11 || !long.TryParse(pesel, out _))
        {
            Console.WriteLine("PESEL musi byc 11 cyfrowa liczba");
            return false;
        }

        int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        int S = 0;

        for (int i = 0; i < 10; i++)
        {
            S += (pesel[i] - '0') * wagi[i];
        }

        int M = S % 10;
        int R;
        if(M==0){
            R=0;
        }
        else{
            R=10-M;
        }

        return R == (pesel[10] - '0');
    }
/* nazwa funkcji: "GetGender"
opis funkcji: sprawdza czy 10-ta liczba peselu jest podzielna przez 2 by stwierdzić plec
parametry: int genderDigit - 10 liczba w peselu
zwracany typ i opis: zmienną o wartości "K lub M" wedlug specyfikacji z której potem wyczytuje plec funkcja main
autor: mateusz */

    static string GetGender(string pesel)
    {
        int genderDigit = pesel[9] - '0';
        return genderDigit % 2 == 0 ? "K" : "M";
    }
}