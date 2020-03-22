using System;
namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Console.WriteLine("Введите десять чисел:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                try
                {
                    nums[i] = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Нужно вводить цифры!");
                }
            }

            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine("Вывод отсортированного массива:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            NumChecker(nums);
            Console.ReadLine();
        }

        private static void NumChecker(int[] arr)
        {
            Console.Write("Введите проверяемое число: ");
            int checkedNum = Int32.Parse(Console.ReadLine());
            foreach (int num in arr)
            {
                if (checkedNum == num)
                {
                    Console.WriteLine($"Число {checkedNum} найдено.");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}