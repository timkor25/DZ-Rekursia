// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
using System;
class Program
{
   static void Main(string[] args)
   {
       int M = 1;
       int N = 5;
       PrintNumbersInRange(M, N);
   }
   static void PrintNumbersInRange(int start, int end)
   {
       if (start <= end)
       {
           Console.Write(start);
           if (start < end)
               Console.Write(", ");
           PrintNumbersInRange(start + 1, end);
       }
   }
}