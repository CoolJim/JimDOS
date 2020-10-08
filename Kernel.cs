﻿using System;
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
            Console.WriteLine("----------");
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
                            Console.WriteLine("=======Help Menu=======");
                            Console.WriteLine("reboot - Restart computer");
                            Console.WriteLine("shutdown - Shutdown computer");
                            Console.WriteLine("hello - Simple OS command");
                            Console.WriteLine("about - Know about OS");
                            Console.WriteLine("keys - Show information about key combinations");
                            Console.WriteLine(" ");

                            break;

                        }

                    case "about":
                    case "info":
                        {

                            Console.WriteLine("JimDOS v" + ver);
                            Console.WriteLine("Written in C#, using COSMOS.");
                            Console.WriteLine("");
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
                          Console.WriteLine("Beeping!");
                          Console.Beep(1000, 1000);
                          Console.WriteLine("");

                          break;
                        }
                        case "keys":
                        case "keystrokes":
                        case "keystroke":
                        {
                            Console.WriteLine("=====Key Combinations=====");
                            Console.WriteLine("Ctrl+Alt+Del - Hard Restart");
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
