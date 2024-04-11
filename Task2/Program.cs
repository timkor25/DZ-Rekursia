﻿using System;			
public class Program
{
	public static void Main()
	{
		// Задание 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
		// m = 2, n = 3 -> A(m,n) = 29
			int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}	
		Console.WriteLine(AkkermanFunc(3,2));
	}
}
