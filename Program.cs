using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                one();
                System.Threading.Thread.Sleep(10000);
                Process[] chrome = Process.GetProcessesByName("chrome");

                foreach (Process p in chrome)
                    p.Kill();
                try
                {
                    two();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e);
                }

            }


                while (true)
                {
                    Console.ReadLine();
                }



       


          
        }
        public static void one()
        {
            Process.Start("https://www.youtube.com/watch?v=BGdGG5_3nig");
        }

        public static void two()
        {
            Process.Start("https://app.joinsurf.com/signup/?r=486f8638-242c-4f7b-8b46-4e40c339d4d9");
        }
    }
}
