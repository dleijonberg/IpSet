using System;
using System.Collections.Generic;

namespace ClassTest
{
    class Program
    {
        static string Printmenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1: New point");
            Console.WriteLine("2: Print all points");
            Console.WriteLine("3: Sort points");
            Console.WriteLine("9: Exit");
            Console.WriteLine();
            Console.Write("Entry: ");
            return Console.ReadLine();
        }

        static PointClass InputPoints(int num)
        {
            int x, y;
            Console.Clear();
            Console.WriteLine();
            Console.Write("X: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Y: ");
            y = Int32.Parse(Console.ReadLine());

            PointClass point = new PointClass(num, x, y);

            return point;
        }

        static void PrintPoint(PointClass point)
        {
            Console.WriteLine("{2}: X={0}, Y={1}", point.x, point.y, point.num);
        }

        static void Sort(Stack<PointClass> stack)
        {
            Stack<PointClass> temp = new Stack<PointClass>();

            while (stack.Count > 0)
            {
                PointClass t = stack.Pop();

                while (temp.Count > 0 && t.num < temp.Peek().num)
                {
                    stack.Push(temp.Pop());
                }

                temp.Push(t);
            }

            while (temp.Count > 0)
                stack.Push(temp.Pop());
        }

        static void Main(string[] args)
        {
            string menuchoice = "";
            Stack<PointClass> points = new Stack<PointClass>();

            while (menuchoice != "9")
            {
                menuchoice = Printmenu();

                switch (menuchoice)
                {
                    case "1":
                        points.Push(InputPoints(points.Count + 1));
                        break;
                    case "2":
                        Console.Clear();
                        foreach (var point in points)
                            PrintPoint(point);
                        Console.WriteLine();
                        Console.Write("Press any key...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Sort(points);
                        break;
                    case "9":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        break;
                }

            }


        }
    }
}
