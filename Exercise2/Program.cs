using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        //Array to be searched //Max number of data 79+20-2x15+10+20 = 99
        int[] arr = new int[99];

        //Number of elements in the array
        int n;

        //Get the number of elements to store in the array
        int i;
        
        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 99))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 99 elements. \n");

            }
            
        }
        static void Main(string[] args)
        {
        }
    }
}
