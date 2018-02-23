using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] firstArraylist = new int[] { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            //int[] secondArraylist = new int[] { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };

            Console.WriteLine("Please Enter the First List size\n");
            int firstlistsize = Int32.Parse(Console.ReadLine());
            int[] firstArraylist = new int[firstlistsize];

            Console.WriteLine("Please Enter the First List Members\n");
            string[] firstArrayString = Console.ReadLine().Split(' ');

            for (int i = 0; i < firstlistsize; i++)
            {
                firstArraylist[i] = Int32.Parse(firstArrayString[i]);
            }

            Console.WriteLine("Please Enter the Second List size\n");
            int secondlistsize = Int32.Parse(Console.ReadLine());
            int[] secondArraylist = new int[secondlistsize];

            Console.WriteLine("Please Enter the Second List Members\n");
            string[] secondArrayString = Console.ReadLine().Split(' ');

            for (int i = 0; i < secondlistsize; i++)
            {
                secondArraylist[i] = Int32.Parse(secondArrayString[i]);
            }
            Console.WriteLine("**********************************************************");
            Console.WriteLine("First List size: " + firstlistsize + "\n");
            Console.WriteLine("First List Members:\n");
            foreach (var item in firstArraylist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Console.WriteLine("**********************************************************");
            Console.WriteLine("Second List size: " + secondlistsize + "\n");
            Console.WriteLine("Second List Members:\n");
            foreach (var item in secondArraylist)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("**********************************************************");



            /*Console.WriteLine("**********************************************************");
            Console.WriteLine("First List and it's size is = " + firstArraylist.Length.ToString());
            foreach (var item in firstArraylist)
                Console.Write(item.ToString() + " ");
            Console.WriteLine();
            Console.WriteLine("**********************************************************");


            Console.WriteLine("Second List and it's size is = " + secondArraylist.Length.ToString());
            foreach (var item in secondArraylist)
                Console.Write(item.ToString() + " ");
            Console.WriteLine();
            Console.WriteLine("**********************************************************");
            */
            var MissingNumberList = FindingMissingNumber(firstArraylist, secondArraylist).ToList();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Missing number from List A");
            foreach (var item in MissingNumberList)
                Console.Write(item.ToString() + " ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************************************************");

            Console.ReadLine();

        }

        /// <summary>
        /// This function is used for finding missing number
        /// </summary>
        /// <param name="firstlist"></param>
        /// <param name="secondlist"></param>
        /// <returns></returns>
        private static IEnumerable<int> FindingMissingNumber(int[] firstlist, int[] secondlist)
        {
            var eachNumberCount = GetMissingCount(firstlist, secondlist);
            return Enumerable.Range(0, eachNumberCount.Length).Where(p => eachNumberCount[p] > 0);
        }

        /// <summary>
        /// This function is used for all number count
        /// </summary>
        /// <param name="firstlist"></param>
        /// <param name="secondlist"></param>
        /// <returns></returns>
        private static int[] GetMissingCount(int[] firstlist, int[] secondlist)
        {
            var NumberDiffrenceCount = new int[10001];

            foreach (var x in firstlist) NumberDiffrenceCount[x]--;

            foreach (var x in secondlist) NumberDiffrenceCount[x]++;

            return NumberDiffrenceCount;
        }

    }
}