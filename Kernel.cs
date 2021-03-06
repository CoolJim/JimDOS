﻿using System;
using Sys = Cosmos.System;

namespace JimDOS
{
    public class Kernel : Sys.Kernel
    {


        protected override void BeforeRun()
        {
            string ver = "1.3.1 [EasyRead]";
            Console.Beep(1000, 1000);
            Console.Clear();
            Console.WriteLine("JimDOS version " + ver);
            Console.WriteLine("Type a command to begin. Type help for basic command usage and user guidance");
            Console.WriteLine("");
        }

        protected override void Run()

        {
            string ver = "1.3.1 [EasyRead]";
            while (true)
            {

                string command = Console.ReadLine();

                switch (command)
                {

                    case "shutdown":
                    case "stop":
                        {
                            Console.WriteLine("Shutting Down");
                            Cosmos.System.Power.Shutdown();
                            break;

                        }

                    case "help":

                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("=======Help Menu=======");
                            Console.WriteLine("reboot - Restart computer");
                            Console.WriteLine("shutdown - Shutdown computer");
                            Console.WriteLine("hello - Simple OS command");
                            Console.WriteLine("about - Know about OS");
                            Console.WriteLine("keys - Show information about key combinations");
                            Console.WriteLine("clear - Clear console screen ");
                            Console.WriteLine("");
                            Console.ResetColor();

                            break;

                        }

                    case "about":
                    case "info":
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.WriteLine("JimDOS v" + ver);
                            Console.WriteLine("Written in C#, using COSMOS.");
                            Console.WriteLine("Thank you for using JimDOS!");
                            Console.WriteLine("");
                            Console.WriteLine("Source Code: https://github.com/CoolJim/JimDOS [Open Source]");
                            Console.ResetColor();
                            break;

                        }

                    case "reboot":
                        {
                            Console.WriteLine("Rebooting");
                            Cosmos.System.Power.Reboot();

                            break;

                        }

                    case "hello":
                        {

                            Console.WriteLine("Hello user! Thanks for using JimDOS");
                            Console.WriteLine("");

                            break;

                        }
                    case "beep":
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("Beeping!");
                            Console.Beep(1000, 1000);
                            Console.WriteLine("");
                            Console.ResetColor();

                            break;
                        }
                    case "keys":
                    case "keystrokes":
                    case "keystroke":
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("=====Key Combinations=====");
                            Console.WriteLine("Ctrl+Alt+Del - Hard Restart");
                            Console.WriteLine("");
                            Console.ResetColor();
                            break;
                        }
                    case "clear":
                        {
                            Console.Clear();
                            Console.WriteLine("JimDOS version " + ver);
                            Console.WriteLine("Type a command to begin. Type help for basic command usage and user guidance");
                            Console.WriteLine("");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("No such command found. Type help for more info");
                            Console.WriteLine("");
                            command = null;

                            break;
                        }
                }

            }
        }
    }
}
