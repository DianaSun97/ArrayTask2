using System;

namespace ConsoleApplication12
{
    internal class Program
    {
        public static Random rand;

        public static void Main(string[] args)
        {
            rand = new Random();
            Console.WriteLine("Random number " + Task1a());

            var arr = Task2b();
            PrintArr(arr);
            Task3(arr);
            var arr1 = count(arr);
            PrintArr(arr1);
            
            var arr2 = count1(arr);
            PrintArr(arr2);
            PrintArr(Multiply(arr2,0.23));

        }


        public static void PrintArr(int[] arr)
        {
            //Распечатать массив используя отдельный метод print
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }
        
        public static void PrintArr(double[] arr)
        {
            //Печать в перегрузке для методоа Multiply
            foreach (double value in arr)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }
        


        public static int Task1a()
        {
            //1.Написать метод генерации целых чисел в пределах -50--1 и 39-125
            // var x = new Random();
            int n = rand.Next(-50, 125);

            while (true)
            {
                if (n >= -1 && n <= 39)
                {
                    n++;
                    continue;
                }
                else
                {
                    break;
                }
            }

            return n;
        }

        public static int[] Task2b()
        {
            //Используя метод заполнить массив длинной 100, использовав только числа >=0
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                int r = Task1a();

                if (r >= 0)
                {
                    arr[i] = r;
                }
                else
                {
                    i--;

                }
            }

            return arr;
        }

        public static void Task3(int[] number)
        {
            int count = 0; //четкий
            int count1 = 0; //не четкий
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    count++;
                }
                else
                {
                    count1++;
                }
            }

            Console.WriteLine(count);
            Console.WriteLine(count1);
        }

        
        public static int counter3 = 0;
        public static int Task4(int min1, int max1, int min2, int max2)
        //Найти максимальное и минимальное значение во всех трех массивах создав для
        //этого методы и перегрузив их для нужных задач в типе данных
        {
            counter3++;
            if (rand.Next(1, 3) == 1)
            {
                return rand.Next(min1, max1);
            }

            return rand.Next(min2, max2);
        }

        
        public static int[] count(int[] number ) //четный массив
        {
            int n = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    n++;
                }
            }

            int[] arr = new int[n];
            int j = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    arr[j] = number[i];
                    j++;
                }
            }

            return arr;
        }
        
        public static int[] count1(int[] number) //нечетный массив
        {
            int n = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    n++;
                }
            }

            int[] arr = new int[n];
            int j = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    arr[j] = number[i];
                    j++;
                }
            }
            return arr;
        }
        
        
        public static double[] Multiply (int[]count,double mul)
            //Все нечетные значения умножить на 0.23 создать с ними новый массив double и распечать его перегрузив метод принт 
        {
            double[]s = new double[count.Length];
            for (int i = 0; i <count.Length ; i++)
            {
                if (count[i] % 2 != 0)
                {
                    s[i] = count[i] * mul;

                }
            }

            return s;
        }
        
}
}