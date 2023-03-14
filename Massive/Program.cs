using System.Xml.Linq;

namespace Massive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WindowWidth = 50;
            // ====================================================
            // ******Создание массива (Одномерные массивы) *******
            // ====================================================
            int[] ArrInt;
            string[] ArrStr;

            int[] ArrInt1 = new int[5];
            string[] ArrStr1 = new string[5];

            Console.WriteLine($"Thitd element = {ArrInt1[2]}"); // вывод пустого (0) элемента массива int
            Console.WriteLine($"Thitd element = {ArrStr1[2]}"); // вывод пустого (null) элемента массива string
            Console.WriteLine(ArrStr1[2] == null); // проверка того, что это null
            ArrStr1[2] = "Hello"; // Присваивание элементу по индексу значения 
            Console.WriteLine($"Thitd element = {ArrStr1[2]}"); // И вывод этого значения


            int[] ArrInt2 = new int[5] { 1, 2, 3, 4, 5 }; // три варианта инициализации
            int[] ArrInt3 = new int[] { 1, 2, 3, 4, 5 }; // массива
            double[] ArrInt4 = { 1.2, 2.4, 3, 4, 5 };

            Console.WriteLine($"Thitd element = {ArrInt3[2]}");  // вывод 3 элмента по индексу

            // ====================================================
            // ****** Создание массива (Многомерные массивы) ******
            // ====================================================

            Console.WriteLine("------------------------------------------------");

            double[,] ArrDouble = new double[,] { { 1, 2, 3, }, // Создание 2-м массива с 
                                                  { 3, 4, 5 } };  // инициализацией
            Console.WriteLine($"Element 2x2 = {ArrDouble[1, 1]}"); // вывод элемнта 2х2 этого массива

            int[,,] Arr3DimInt = new int[,,] { { { 1, 2, 3 }, { 3, 4, 5 } },
                                               { { 6, 7, 8 }, { 9, 10, 11 } } };
            Console.WriteLine($"Element 2x2х3 = {Arr3DimInt[1, 1, 2]}");

            // ====================================================
            // *************** Цикл форич *************************
            // ====================================================

            Console.WriteLine("------------------------------------------------");

            Console.Write("Вывод одномерногоо массива: ");
            foreach (var item in ArrInt4)
            {
                Console.Write($"{item} ");
            }

            Console.Write("\nВывод двухмерного массива: ");
            foreach (var item in ArrDouble)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n------------------------------------------------");

            // ====================================================
            // ************ Методы массива ***********************
            // ====================================================

            Console.WriteLine($"Massive Lenth = {ArrInt2.Length}"); // длина массива
            ArrToConsole(ArrInt2, "Ishodny Massive:"); // нужно перейти к созданию своего метода!!!
            Array.Reverse(ArrInt2);
            ArrToConsole(ArrInt2, "Reverse Massive:");
            Array.Reverse(ArrInt2, 2, 3); // переворачиваем только часть массива с 2 индекса - 3 элемента
            ArrToConsole(ArrInt2, "Reverse Part of Massive:");
            int[] A = new int[10];
            ArrInt2.CopyTo(A, 2); // копирование массива ArrInt2 в А с 2 индекса
            ArrToConsole(A, "Massive copy");
            int[] B = new int[10];
            Array.Copy(ArrInt2, B, 3); // копирование трех эл. массива ArrInt2 в В 
            ArrToConsole(B, "Massive copy");
            int[] C = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array.Resize(ref C, 5); // изменение размера массива
            ArrToConsole(C, "Resized Massive");

            Random rnd = new Random();
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = rnd.Next(1, 10);
            }
            ArrToConsole(C, "Random Massive");

            Array.Sort(C); // сортировка массива
            ArrToConsole(C, "Sorted Massive");

            Console.WriteLine($"UpperBound {ArrDouble.GetUpperBound(1)}"); // макс индекс столбцов массива

            int min = C.Min(); int max = C.Max(); int sum = C.Sum(); // min, max, summa elementov
            Console.WriteLine($"Мin el = {min}; Max el = {max}; Sum = {sum}");

            ArrToConsole(ArrInt4, "Double Array:"); //перегруженный метод для вывода дабл массива

            // поиск индексов элементов массива
            int[] myArray = { 3, 5, 4, 7, 8, 5, 1 };
            int ind = myArray[1]; // т.о. можно найти кол-во уникальных элеметов масссива
            Console.WriteLine($"First index of element {Array.IndexOf(myArray, ind)}");
            Console.WriteLine($"Last index of element {Array.LastIndexOf(myArray, ind)}");

            //================================================================================
            //Задание 1
            //Создайте приложение, которое отображает количество
            //чётных, нечётных, уникальных элементов массива
            //================================================================================

            // Зубчатые (рваные) массивы
            int[][] rArray = new int[2][];
            rArray[0] = new int[] { 4, 5 };
            rArray[1] = new int[] { 10, 11, 12, 13, 15 };

            Console.WriteLine($"Значение элемета массива {rArray[1][3]}");
            // Console.WriteLine($"Значение элемета массива {rArray[0][3]}"); // Исключение!!!


            //================================================================================
            //Задание 2
            //Создать и вывести зубчатый масси с помощью цикла форич
            //================================================================================

            //// Задание на форич и зубчатый массив
            //foreach (var item in rArray)
            //{
            //    Console.WriteLine();
            //    foreach (var item1 in item)
            //    {
            //        Console.Write($"{item1,-3}");
            //    }
            //}



        }
        static void ArrToConsole(int[] arr, string message)
        {
            Console.Write(message);
            foreach (var item in arr)
            {
                Console.Write($"{item,2}");
            }
            Console.WriteLine();
        }

        static void ArrToConsole(double[] arr, string message)
        {
            Console.Write(message);
            foreach (var item in arr)
            {
                Console.Write($"{item,5:f2}");
            }
            Console.WriteLine();
        }


        //static (int, int) Myfunction(int x)
        //{
        //    return (x*2, x*3);
        //}           

        // int kv, kub;
        //( kv, kub) = Myfunction(3);
        // Console.WriteLine(kub.ToString() );
    }
}