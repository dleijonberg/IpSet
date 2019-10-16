using System;
using NetworkAdapter;

namespace NetworkAdapterTestConsole
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Nics NicClass = new Nics();
            // Nics.NicInfo CurrentAdapter;

            foreach (var Nic in NicClass.NicList)
            {
                Console.WriteLine("{0}: {1}", Nic.num, Nic.Name);
                //Console.WriteLine("   {0}", NicClass.NicList[i].ID);
                //Console.WriteLine();
            }
            Console.Write("Which adapter? ");
            
            int num = Int32.Parse(Console.ReadLine());

            //NicClass.GetNicInfo(NicClass.NicList[num].Name);
            Console.WriteLine("Name: {0}", NicClass.NicList[num].Name);
            Console.WriteLine("{0}", NicClass.NicList[num].IpAddress);
            Console.WriteLine("{0}", NicClass.NicList[num].Ipv4Mask);
            Console.WriteLine("{0}", NicClass.NicList[num].Gateway);

            Console.ReadKey();
        }
    }
}
