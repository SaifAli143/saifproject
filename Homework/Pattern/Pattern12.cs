﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Homework.Pattern
{
    class Pattern12
    {
		static void Main(string[] args)
		{

			int rows = 5;
			for (int i = 1; i <= rows; i++)
			{
				for (int j = rows; j > i; j--)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= (i * 2) - 1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
