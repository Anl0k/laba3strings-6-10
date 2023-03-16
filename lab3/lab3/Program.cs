using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 6
            Console.Write("Введите первую строку: ");
            string first = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string second = Console.ReadLine();
            string third = first + ' ' + second;
            string[] str = third.Split(' ');
            int z = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Contains("da"))
                { z++; }
            }
            Console.WriteLine(z);


            // задание 7
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] stroka = input.Split(' ', ',', '.', ':', '!', '?', ';');

            int maxlen = 0, index = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i].Length > maxlen)
                {
                    maxlen = stroka[i].Length;
                    index = i;
                }
            }
            string input1 = input.Replace(stroka[index], "");
            string otvet = stroka[index] + ' ' + input1;
            Console.Write(otvet);
            Console.ReadLine();

            // задание 8
            Console.Write("Введите строку: ");
            string input8 = Console.ReadLine();
            int z8 = 0;

            for (int i8 = 0; i8 < input8.Length; i8++)
            {
                if ((i8 % 2) != 0)
                { if (input8[i8].Equals('y')) { z8++; } }
            }
            Console.WriteLine(z8);

            // задание 9
            Console.Write("Введите строку: ");
            string input9 = Console.ReadLine();
            Console.WriteLine(input9.Replace('a', 'A'));

            // задание 10
            Console.Write("Введите слово: ");
            string input10 = Console.ReadLine();
            int a = input10.Length - 1;
            int z10 = 0;
            int k10 = 0;

            for (int i10 = 0; i10 < input10.Length; i10++)
            {
                if (input10[i10] == input10[0])
                { z10++; }
                if (input10[i10] == input10[a])
                { k10++; }
            }

            if (z10 > k10) { Console.WriteLine("Первая буква встречается в этом слове чаще"); }
            if (z10 < k10) { Console.WriteLine("Последняя буква встречается в этом слове чаще"); }
            if (z10 == k10) { Console.WriteLine("Первая и последняя буква встречаются в этом слове одинаково часто"); }
        }
    }
}