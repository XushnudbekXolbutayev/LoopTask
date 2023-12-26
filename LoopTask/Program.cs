using System.ComponentModel.DataAnnotations;

namespace LoopTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // While Loop, sum of numbers from 1 to 1000
            int OddNum = 1;
            int summ = 0;
            while(OddNum < 1000){

                summ += OddNum;
                OddNum += 2;

            }

            Console.WriteLine(summ);

            //Multiplication of the min and max values of an array
            int[] arr = new int[6];
            Console.WriteLine("Enter the optional numbers!");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //First way
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int k = arr[i];
                        arr[i] = arr[j];
                        arr[j] = k;
                    }
                }
            }
            Console.WriteLine($"Minimum qiymat x Maximum qiymat = {arr[0] * arr[5]}");

            //Second way
            int min = arr[0];
            int max = 0;
            for (int i = 1;i < arr.Length; i++)
            {
                if (min > arr[i])
                { min = arr[i]; }
                else {  max = arr[i]; }
                
            }

            Console.WriteLine($"Minimum qiymat x Maximum qiymat = {min * max}");

            // code that calculates the factorial

            int OptionalNumb = 1;
            int Multp = 1;
            Console.Write("Enter the number: ");
            int opt = Convert.ToInt32(Console.ReadLine());

            do
            {
                OptionalNumb++;
                Multp *= OptionalNumb;
            }while(OptionalNumb < opt);

            Console.WriteLine(Multp);
        }
    }
}
