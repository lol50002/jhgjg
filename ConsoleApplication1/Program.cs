using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        int a = 55;
                        int b = 0;
                        a = a / b;
                        break;
                    case "2":
                        int c = 0;
                        int[] array = new int[10];
                        array[100] = 100;
                        break;
                    case "3":
                        Int32 h;
                        h = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "4":
                        int pop = int.MaxValue;
                        pop = checked(pop+1);
                        break;
                }
                // int a = 55;
                //int b = 0;
                // a = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("ААААААААААААААААА");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("HHHHHH");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ХХХАААА");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EE{F");
            }

            



        }
    }
}
