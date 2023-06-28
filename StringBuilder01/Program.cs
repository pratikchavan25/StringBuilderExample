using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder1
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello to all");
            Console.WriteLine("\n" + sb);
            Console.WriteLine(sb.GetHashCode());//in StringBuilder gethashcode gives same address location

            sb.Append("Good Morning");
            Console.WriteLine("\n" + sb);
            Console.WriteLine(sb.GetHashCode());

            sb.Insert(5, "TEST DATA");
            Console.WriteLine("\n" + sb);

            sb.Remove(5, 4);
            Console.WriteLine("\n" + sb);

            sb.Replace("DATA", "new data");
            Console.WriteLine("\n" + sb);


            StringBuilder sb3 = new StringBuilder("You amount is ");

            sb3.AppendFormat("{0:C}", 25000); // C --> currency

            Console.WriteLine(sb3);


        }
    }

}
