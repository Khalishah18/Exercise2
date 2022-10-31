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
        //arr = lis (nickname)
        int[] lis = new int[99];

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
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("---------------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                String s1 = Console.ReadLine();
                lis[i] = Int32.Parse(s1);
            }
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be searched
                Console.Write("\n Enter element want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the middle elements
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array
                while ((item != lis[mid]) && (lowerbound <= upperbound))
                {
                    if (item > lis[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == lis[mid])
                    Console.WriteLine("\n" + item.ToString() + " found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " not found iin the array \n");
                Console.WriteLine("\nNumber of comparasion : " + ctr);

                Console.Write("\nContinue Search (y/n):");
                ch = char.Parse(Console.ReadLine());
                
            } while ((ch == 'y') || (ch == 'Y'));
        }
        public void LinearSearch()
        {
            char ch;
            //search for number of comparison
            int ctr;
            do
            {
                //accept the number to be searched
                Console.Write("\nEnter the element you want to search: ");
                int item = Convert.ToInt32((Console.ReadLine()));

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (lis[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + "found st position " + (i + 1).ToString());
                        break;
                    }
                    
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "not found in the array");
                Console.WriteLine("\n Number of comparison " + ctr);
                Console.WriteLine("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("==================");
                Console.WriteLine("1. Linear Search");
                Console.WriteLine("2. Binary Search");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());
                
                switch(pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine(". . .  . . . . . . . . .");
                        Console.WriteLine("Linear Search");
                        Console.WriteLine(". . .  . . . . . . . . .");
                        myList.input();
                        myList.LinearSearch();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine(". . . . . . . . . . . . .");
                        Console.WriteLine("Binary Search");
                        Console.WriteLine("");
                        myList.input();
                        myList.BinarySearch();
                        break;
                    case 3:
                        Console.WriteLine("Exit.");
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
                //to exit from the console
                Console.WriteLine("\n\n Press Return to Exit. ");
                Console.ReadLine();
            }while (pilihanmenu != 3);
        }
    }
}
