using System;
using NetworkAdapter;

namespace NetworkAdapterTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Nics NicClass = new Nics();
            NicClass.UpdateNics();
            // Nics.NicInfo CurrentAdapter;

            for(int i = 0; i < NicClass.NicList.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i, NicClass.NicList[i].Name);
                //Console.WriteLine("   {0}", NicClass.NicList[i].ID);
                //Console.WriteLine();
            }
            Console.Write("Which adapter? ");
            string input = Console.ReadLine();
            int num = Int32.Parse(input);

            NicClass.GetNicInfo(NicClass.NicList[num].Name);
        }
    }
}
