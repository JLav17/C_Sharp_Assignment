using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_1
{
    internal class Question_9
    {
        static void Main(string[] args)
        {
            int[] ids = { 102, 215, 102, 324, 215 };
            List<int> uniqueList = new List<int>();

            for (int i = 0; i < ids.Length; i++)
            {
                if (!uniqueList.Contains(ids[i]))
                {
                    uniqueList.Add(ids[i]);
                }
            }

            Console.WriteLine("Unique IDs:");
            foreach (int id in uniqueList)
            {
                Console.WriteLine(id);
            }
        }
    }
}
