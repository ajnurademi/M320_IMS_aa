using System;

namespace OO_Function
{

    /*
    Grundlegende Sprachelemente von C# anzuwenden
    Autor: Ajnur Ademi
    Datum: 24.08.2023
    Version: 1.0
    */


    class Program
    {
        static void Main(string[] args)
        {
            // Eingabe Users solange bis beendet
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. ggT berechnen");
                Console.WriteLine("2. kgV berechnen");
                Console.WriteLine("3. Statistiken über Zahlen");
                Console.WriteLine("4. Zahlen umdrehen");
                Console.WriteLine("5. Zahlen sortieren");
                Console.WriteLine("6. beenden");
                Console.Write("Wählen Sie eine Option: ");
                int choice = int.Parse(Console.ReadLine());

                // Eingabe nach Funktion auswerten 
                switch (choice)
                {
                    case 1:
                        int num1 = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                        int num2 = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                        int gcd = MyMath.Calc_ggT(num1, num2);
                        MyMath.ShowResult("ggT", num1, num2, gcd);
                        break;

                    case 2:
                        num1 = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                        num2 = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                        int lcm = MyMath.Calc_kgV(num1, num2);
                        MyMath.ShowResult("kgV", num1, num2, lcm);
                        break;

                    case 3:
                        int arraySize = MyMath.ReadInt("Geben Sie die Anzahl der Zahlen ein: ");
                        int[] numbers = new int[arraySize];
                        for (int i = 0; i < arraySize; i++)
                        {
                            numbers[i] = MyMath.ReadInt($"Geben Sie Zahl {i + 1} ein: ");
                        }
                        Console.WriteLine($"Arithmetischer Mittelwert: {MyMath.CalculateMean(numbers)}");
                        Console.WriteLine($"Kleinster Wert: {MyMath.FindSmallest(numbers)}");
                        Console.WriteLine($"Größter Wert: {MyMath.FindLargest(numbers)}");
                        break;

                    case 4:
                        arraySize = MyMath.ReadInt("Geben Sie die Anzahl der Zahlen ein: ");
                        numbers = new int[arraySize];
                        for (int i = 0; i < arraySize; i++)
                        {
                            numbers[i] = MyMath.ReadInt($"Geben Sie Zahl {i + 1} ein: ");
                        }
                        MyMath.ReverseArray(numbers);
                        Console.WriteLine("Zahlen umgedreht:");
                        foreach (int num in numbers)
                        {
                            Console.Write($"{num} ");
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        arraySize = MyMath.ReadInt("Geben Sie die Anzahl der Zahlen ein: ");
                        numbers = new int[arraySize];
                        for (int i = 0; i < arraySize; i++)
                        {
                            numbers[i] = MyMath.ReadInt($"Geben Sie Zahl {i + 1} ein: ");
                        }
                        MyMath.SortArray(numbers);
                        Console.WriteLine("Zahlen sortiert:");
                        foreach (int num in numbers)
                        {
                            Console.Write($"{num} ");
                        }
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine("Danke für Ihr Besuch ! ");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Ungültige Option. Bitte wählen Sie erneut.");
                        break;
                }
            }
        }
    }
}
