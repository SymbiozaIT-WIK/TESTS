using System;
using System.Collections.Generic;
using TESTS.Helpers;

namespace TESTS
{
    class Program
    {
        static void Main(string[] args)
        {
            /////// PYTANIA // ASP .NET MVC // EF // ////////////
            // Pyt1. Jaka jest różnica pomiędzy ViewData i TempData (.NET MVC)
            // Pyt2. Czym jest AntiForgeryToken (.NET MVC)
            // Pyt3. Jak uruchomić kod (np. zapis godziny dostępu do podstrony) w kontrolerze MVC przed uruchomieniem każdej zawartej w nim metody? (.NET MVC)
            // Pyt4. Czym jest pojęcie CodeFirst (EntityFramework)
            // Pyt5. Czym jest LazyLoading i EagerLoading (dodatkowo możesz podać przykłady) (EntityFramework)


            // ZADANIE 1 //////////////////////////////////////////////////////////////
            // Dlaczego kod się nie kompiluje? /////////////////////////
            // Podaj możliwe rozwiązanie

            //bool a = false;
            //int? b = a == true ? 1 : null;
            //Console.WriteLine(b);



            // ZADANIE 2 //////////////////////////////////////////////////////////////
            // Co zostanie wypisane na ekran?
            // Dodaj opcjonalną możliwość pomijania liczenia białych znaków (spacja)

            var text = "Ala ma kota...";
            var result = Basic.CountLetters(text);
            foreach (var keyValue in result)
                Console.WriteLine($"Znak: {keyValue.Key} Ilość wystąpień: {keyValue.Value}");



            // ZADANIE 3 //////////////////////////////////////////////////////////////
            // (operacje na kolekcjach / LinQ)
            //Wypisz posortowaną listę
            //Każda liczba powinna zostać wypisana w konsoli tylko raz! 

            List<int> numList = new List<int>
            {
                4,13,5,1,75,2,23,25,67,745,23,264,75,2,23,5,1,75,2,23,25,67,745,
                23,264,7,5,1,75,2,23,25,67,745,232,23,5,1,75,2,23,25,67,745,2,2,
                264,75,2,23,5,1,75,2,23,22,75,2,23,5,1,75,2,23,264,75,2,235,2,2
            };

            foreach (var number in numList)
                Console.WriteLine(number);


            // Zadanie 4 //////////////////////////////////////////////////////////////
            // Napisz funkcję w klasie Basic przestrzeni nazw TESTS.Helpers,
            // która jako parametr przyjmuje tablicę Tab liczb całkowitych 
            // i zwraca najmniejszą dodatnią liczbę całkowitą N (dla N > 0) 
            // która nie występuje w podanej tablicy Tab

            ///PRZYKŁAD: 
            /// Tab = [0, 1, 2] - funkcja zwraca 3
            /// Tab = [-1, -2] - funkcja zwraca 1

            Console.ReadKey(true);
        }

        


    }
}
