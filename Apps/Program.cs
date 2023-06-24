using System.Collections;

namespace Apps
{
    class Program
    {

        public static void Main(string[] args)
        {
            //var arr = new DataStructers.Array.Array<int>();
            //var arr = new DataStructers.Array.Array<int>(25,45,60,40,80);

            /*var p1 = new DataStructers.Array.Array<int>(1,2,3,5);
            var p2 = new int[] {8,9,10};
            var p3 = new List<int>() { 4,6,45,976};
            var p4 = new ArrayList() { 12, 65, 47 };    //Getting error due to the fact that ArrayList cant convert to int

            var arr = new DataStructers.Array.Array<int>(p1);*/

            var arr = new DataStructers.Array.Array<int>();
            for (int i = 0; i < 128; i++)
            {
                arr.Add(i+1);
                Console.WriteLine($"{i+1} has been added to array.");
                Console.WriteLine($"{arr.Count}/{arr.Capacity}");
            }
            Console.WriteLine();
            for (int i = arr.Count; i >= 1; i--)
            {
                Console.WriteLine($"{arr.Remove()} has been removed from the array");
                Console.WriteLine($"{arr.Count}/{arr.Capacity}");
            }

            /*arr.Add(23);
            arr.Add(55);
            arr.Add(44);
            arr.Add(55);
            arr.Add(50);
            */

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*******************");

            arr.Where(x => x%2 == 0).ToList().ForEach(x => Console.WriteLine(x));
            //Console.WriteLine($"{arr.Count} / {arr.Capacity}");


            Console.ReadKey();
        }
    }
}