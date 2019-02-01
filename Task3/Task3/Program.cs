using System;


namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // размер массива 
            int[] arr = new int[a];
            string[] s = Console.ReadLine().Split(); // сохраняем числа в виде стринга 
            for (int i = 0; i < arr.Length; i++) // фор
            {
                arr[i] = int.Parse(s[i]); // даю стрингам значение числа 
                Console.Write(arr[i] + " " + arr[i] + " ");//выписываю числа два раза подряд 

            }
            Console.ReadKey();
        }
    }
}