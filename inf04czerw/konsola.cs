using System;

class Program
{
    static void Main()
    {
        
        int[] numbers = new int[51];
        numbers=fillArray(numbers);
        
        

        Console.WriteLine();

        int userNumber=0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.WriteLine("Podaj liczbe:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userNumber))
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("trzeba podać liczbe");
            }
        }

        numbers[50] = userNumber;

        for (int i = 0; i < 51; i++)
        {
            Console.WriteLine($"{i + 1}. {numbers[i]}");
        }

      int found=  SearchNumber(numbers, userNumber);
        if (found == 50)
        {
            Console.WriteLine("Nie ma numeru.");
        }
        else
        {
            Console.WriteLine($"Znaleziono numer na pozycji {found + 1}.");
        }
    }
    
 /*   nazwa funkcji: SearchNumber
 argumenty: array - przechowuje tabele
target - przechowuje wybraną / szukaną liczbe
check - dostaje pozycje na tabeli gdzie po raz pierwszy znaleziona jest liczba szukana
 typ zwracany: int - zrwacany jest "check" czyli pozycja gdzie jest znaleziona liczba
 po raz pierwszy według specyfikacji
 informacje: otrzymuje tabele i szukaną liczbe, sprawdza pokolei czy dana komurka w tabeli
 jest taka sama co szukana i jesli tak to zapamiętuje tą pozycje i przerywa szukanie po 
 czym zwraca pozycje. na samym końcu jest napewno liczba szukana bo zostala tam dodana jako
 "wartownik" wiec jest to algorytm szukania z wartownikiem
 autor: zajac */

    static int SearchNumber(int[] array, int target)
    {
        int check = 51;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                check = i;
                i=60;
            }
        }
return check;
        
    }
    
    static int[] fillArray(int[] array){
        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
            array[i] = random.Next(1, 100);
        }
        return array;
    }
}