﻿using System;

namespace TestLeaf.Helpers
{
    class LogUtil
    {
        public static void Log(string message)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("INFO: " + message);
        }
    }
}
