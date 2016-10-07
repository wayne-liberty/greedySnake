﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Example
{
    public static void Main()
    {
        ConsoleKeyInfo key;
        bool moved = false;

        Console.BufferWidth = 120;
        Console.Clear();

        ShowConsoleStatistics();
        do
        {
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.LeftArrow)
            {
                int pos = Console.WindowLeft - 1;
                if (pos >= 0 && pos + Console.WindowWidth <= Console.BufferWidth)
                {
                    Console.WindowLeft = pos;
                    moved = true;
                }
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                int pos = Console.WindowLeft + 1;
                if (pos + Console.WindowWidth <= Console.BufferWidth)
                {
                    Console.WindowLeft = pos;
                    moved = true;
                }
            }
            if (moved)
            {
                ShowConsoleStatistics();
                moved = false;
            }
            Console.WriteLine();
        } while (true);
    }

    private static void ShowConsoleStatistics()
    {
        Console.WriteLine("Console statistics:");
        Console.WriteLine("   Buffer: {0} x {1}", Console.BufferHeight, Console.BufferWidth);
        Console.WriteLine("   Window: {0} x {1}", Console.WindowHeight, Console.WindowWidth);
        Console.WriteLine("   Window starts at {0}.", Console.WindowLeft);
        Console.WriteLine("Press <- or -> to move window, Ctrl+C to exit.");
    }
}

