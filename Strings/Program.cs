using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple constractor
            string s = "Hello World!";
            Console.WriteLine($"Smple constractor: {s}");
            Console.WriteLine("------------------------------------------------------");
            // Other constractors
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };
            Console.WriteLine($"Other constractor: {new string(chars)}");
            Console.WriteLine($"Other constractor: {new string(chars, 2, 2)}");
            Console.WriteLine($"Other constractor: {new string('*', 5)}");
            Console.WriteLine("------------------------------------------------------");
            // esc-seq and @
            string strPath1 = "D:\\Student\\MyProjects\\Strings\\";
            string strPath2 = @"D:\Student\MyProjects\Strings\";
            Console.WriteLine(strPath1);
            Console.WriteLine(strPath2);
            Console.WriteLine("------------------------------------------------------");
            // into char array
            char[] chars1 = new char[5];
            s.CopyTo(0, chars1, 0, 5);
            Console.WriteLine(chars1);

            char[] chars2 = s.ToCharArray();
            Console.WriteLine(chars2);
            Console.WriteLine("------------------------------------------------------");
            // string compare
            string s1 = "good";
            string s2 = "good";
            string s3 = "bad";
            Console.WriteLine("the strings are equal: " + s1.Equals(s2));
            Console.WriteLine("the strings are NOT equal: " + s1.Equals(s3));
            Console.WriteLine("the strings are equal " + s1.CompareTo(s2));
            Console.WriteLine("the strings are NOT equal " + s1.CompareTo(s3));
            Console.WriteLine("the strings are equal " + String.Compare(s1, s2));
            Console.WriteLine("the strings are NOT equal " + String.Compare(s3, s1));

            Console.WriteLine("------------------------------------------------------");

            // indexOf and other
            Console.WriteLine("IndexOf: " + s1.IndexOf('o'));
            Console.WriteLine("LastIndexOf: " + s1.LastIndexOf('o'));
            Console.WriteLine("IndexOf Any: " + s1.IndexOfAny(s3.ToCharArray()));

            Console.WriteLine("------------------------------------------------------");

            // change
            string s4 = "Hello";
            Console.WriteLine("To Upper: " + s4.ToUpper());
            Console.WriteLine("To Upper: " + s4.ToLower());
            Console.WriteLine("Replace: " + s4.Replace('e', 'a'));
            Console.WriteLine("Insert: " + s4.Insert(2, "kk"));
            Console.WriteLine("Remove: " + s4.Remove(2, 2));
            string s5 = "Hello World";
            Console.WriteLine("Split: " + s5.Split(' ')[0]);
            string[] sM = s5.Split(' ');
            Console.WriteLine("Join: " + String.Join(' ', sM));
            string st1 = "Hello "; string st2 = "  World";
            Console.WriteLine("without trim: " + String.Concat(st1, st2));
            Console.WriteLine("witht trim: " + String.Concat(st1.Trim(), st2.Trim()));

            // format
            double a = Math.PI; int b = 100000;
            string sF = String.Format("First number = {0,5:f2}; Second number = {1:E2}", a, b);
            Console.WriteLine(sF);

            Console.WriteLine("------------------------------------------------------");

            // StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello"); sb.Append(' '); sb.Append("World!"); // во втором выражении можно исп. и " "
            Console.WriteLine("From StringBuilder: " + sb.ToString());
            Console.WriteLine("Remove: " + sb.Remove(4, 1));
            Console.WriteLine("Lenth: " + sb.Length);
            Console.WriteLine("Capacity: " + sb.Capacity);
            Console.WriteLine("MaxCapacity: " + sb.MaxCapacity);
            Console.WriteLine("Replace: " + sb.Replace('o', ' '));

            //================================================================================
            //Пользователь вводит предложение с клавиатуры.Вам
            //необходимо перевернуть каждое слово предложения и
            //отобразить результат на экран.
            //Например:
            //пользователь ввёл: sun cat dogs cup tea;
            //после переворота:  nus tac sgod puc aet.

            //Пользователь вводит предложение с клавиатуры.Вам
            //необходимо подсчитать количество слов в нём.

            //================================================================================


            //string s333 = "sun cat dogs cup tea";
            //string[] sM333 = s333.Split(" ");

            //char[][] sCh333 = new char[sM333.Length][];
            //int i = 0;
            //foreach (var item in sM333)
            //{
            //    sCh333[i]  = item.ToCharArray();
            //    Array.Reverse(sCh333[i]);
            //    i++;
            //}
            //string rez = ""; string rez1 = "";

            //for (int j = 0; j < sCh333.Length; j++)
            //{
            //    rez += new string(sCh333[j])+ " ";
            //}
            //Console.WriteLine(s333);
            //Console.WriteLine(rez.Trim());



















        }
    }
}