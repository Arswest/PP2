using System;

namespace Introduction
{
    class MainClass
    {
        public static bool isPrime(int a){
            if (a == 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++){
                if (a % i == 0) return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            string line = Console.ReadLine(); // Считывание строки с консоли
            string[] numbers = line.Split(' ');// Разделение чисел пробелом
            for (int i = 0; i < numbers.Length; i++){ // кол-во чисел в массиве 
                if (isPrime(int.Parse(numbers[i]))){ // проверка числа на простоту
                    Console.WriteLine(numbers[i]); // выводит простые числа
                }
            }
            Console.ReadKey();
        }
    }
}
