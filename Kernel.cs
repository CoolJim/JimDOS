using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace JimDOS
{
    public class Kernel : Sys.Kernel
    {
        Canvas canvas;
        public static void clear()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


        }
        protected override void BeforeRun()
        {
            Console.Beep(1000, 1000);
            clear();
            Console.WriteLine("Hello user! Welcome to JimDOS. You have successfully booted.");
            Console.WriteLine("Type a command to begin. Type help for basic command usage and user guidance");
            Console.WriteLine(" ");
        }

        protected override void Run()
        {
            while (true)
            {

                string command = Console.ReadLine();

                switch (command)
                {

                    case "shutdown":
                        {
                            Console.WriteLine("Shutting Down in 5 Seconds");
                            System.Threading.Thread.Sleep(5000);
                            Cosmos.System.Power.Shutdown();
                            break;

                        }

                    case "help":

                        {
                            Console.WriteLine("reboot - Restart computer");
                            Console.WriteLine("shutdown - Shutdown computer");
                            Console.WriteLine("hello - Simple OS command");
                            Console.WriteLine("about - Know about OS");

                            break;

                        }

                    case "about":

                        {

                            Console.WriteLine("JimDOS v1.2.0");
                            Console.WriteLine("Written in C#, using COSMOS.");
                            break;

                        }

                    case "reboot":
                        {
                            Console.WriteLine("Rebooting in 5 seconds");
                            System.Threading.Thread.Sleep(5000);
                            Cosmos.System.Power.Reboot();

                            break;

                        }

                    case "hello":
                        {

                            Console.WriteLine("Hello! Thanks for using JimDOS");

                            break;

                        }

                    default:
                        {
                            Console.WriteLine("No such command found. Type help for more info");

                            command = null; break;
                        }
                }

            }
        }
    }
}
