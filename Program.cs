using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
              number[0] = 67;
              number[1] = 78;
              number[2] = 56;
              number[3] = 98;
              number[4] = 85;

            int[] number1 = new int[5] {67,78,56,98,85 };
            int[] number2 = {67,78,56,98,85 };

            for(int count=0; count<number.Length; count++)
            {
                Console.WriteLine("Array in position " +count+ " : " + number[count]);
            }

            //Reverse Array
            int[] num = { 67, 78, 56, 98, 85 };
            Array.Reverse(num);
            Console.WriteLine("Reverse Array : ");

            for (int i = 0; i<num.Length; i++ )
            {
                Console.WriteLine(num[i]);
            }

            //Sorting Array
            Array.Sort(num);
            Console.WriteLine("Sorting Array : ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            //Inserting the array values from user
            for (int count = 0; count < number.Length; count++)
            {
                Console.WriteLine("Enter array element " + count);
                number[count] = Convert.ToInt32(Console.ReadLine());
            }

            //Showing the values
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }

            string[] cities = { "Mumbai", "London", "New York", "Pune" };

            for (int count = 0; count < cities.Length; count++)
            {
                Console.WriteLine("String Array Position " + count + " : " + cities[count]);
            }

            Console.ReadLine();
        }
    }
}
