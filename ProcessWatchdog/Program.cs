﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessWatchdog
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var watchdog = new ProcessWatchdog("WinRAR", @"C:\Program Files\WinRAR\WinRAR.exe", TimeSpan.FromSeconds(30));

            // Keep console open until a key is pressed
            Console.ReadKey();

            watchdog.TerminateProcess();
        }
    }
}
