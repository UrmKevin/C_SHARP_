using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Console.WriteLine("Vajuta mingi klahv!!!");
                k = Console.ReadKey();
                Console.Beep();
            } while (k.Key!=ConsoleKey.Escape);
            Environment.Exit(0);
            double price = 10;
            price = price / 30;
            price = price * 100;
            string pilet_type = "";
            Console.WriteLine("Ur name?");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Welcome! {0}", eesnimi);
            if (eesnimi.ToLower() == "dan")
            {
                Console.WriteLine("Come over :) Do you want to go to the cinema?");
                string vaastus = Console.ReadLine();
                if (vaastus.ToUpper() == "YES" || vaastus.ToUpper() == "YEP")
                {
                    Console.WriteLine("How old are u?");
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus < 0 || vanus > 108)
                    {
                        Console.WriteLine("You are not allowed!");
                        pilet_type = "not allowed";
                    }
                    else if (vanus >= 6 && vanus < 12)
                    {
                        price -= price * 0.3;
                        pilet_type = "children";
                    }
                    else if (vanus >= 12 && vanus < 18)
                    {
                        price -= price * 0.1;
                        pilet_type = "default";
                    }
                    else if (vanus < 6 || vanus >= 65)
                    {
                        price -= price * 1;
                        pilet_type = "free";
                    }
                    eesnimi = eesnimi.ToLower();
                    Console.WriteLine("{0}, you'll need to pay {1} euro", UppercaseFirst(eesnimi), price, Console.Title);
                }
                else
                {
                    Console.WriteLine("Okay :(");
                }
            }
            else
            {
                Console.WriteLine("I'm not waiting for you! :(");
            }
        }
        static string UppercaseFirst(string s) //to make string's first letter upper
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);

            //---------------------------------------------

            //Console.WriteLine("Write 2 names");
            //string name1 = Console.ReadLine();
            //string name2 = Console.ReadLine();
            //if (name1.ToLower() == "kevin" && name2.ToLower() == "german" || name1.ToLower() == "german" && name2.ToLower() == "kevin")
            //{
            //    Console.WriteLine("yes");
            //}
            //else if (name1.ToLower() == "angelina" && name2.ToLower() == "ilja" || name1.ToLower() == "ilja" && name2.ToLower() == "angelina")
            //{
            //    Console.WriteLine("yes");
            //}
            //else if (name1.ToLower() == "ilja" && name2.ToLower() == "anton" || name1.ToLower() == "anton" && name2.ToLower() == "ilja")
            //{
            //    Console.WriteLine("yes");
            //}
            //else if (name1.ToLower() == "artem" && name2.ToLower() == "timofei" || name1.ToLower() == "timofei" && name2.ToLower() == "artem")
            //{
            //    Console.WriteLine("yes");
            //}
            //else if (name1.ToLower() == "artem" && name2.ToLower() == "denis" || name1.ToLower() == "denis" && name2.ToLower() == "artem")
            //{
            //    Console.WriteLine("yes");
            //}
            //else if (name1.ToLower() == "martin" && name2.ToLower() == "empty" || name1.ToLower() == "empty" && name2.ToLower() == "martin")
            //{
            //    Console.WriteLine("yes");
            //}

            //----------------------------------------

            //Console.WriteLine("Write 2 ");


            //Console.ReadKey();
        }
    }
}
