using System;
using System.Collections.Generic;
using System.Threading;

namespace FallingRocks
{
    class Game
    {
        static char[] r = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        static Random rand = new Random();
        static List<Rock> rocks;
        static int playGroundWidth = 50;
        public class Dwarf
        {
            private static Dwarf instance = null;
            private string body;
            private int x;
            private Dwarf()
            {
                body = "(0)";
                x = playGroundWidth / 2 - 1;
                Print();
            }
            public static Dwarf GetInstance()
            {
                if (instance == null)
                {
                    instance = new Dwarf();
                }
                return instance;
            }
            public void MoveLeft()
            {
                if (x > 0)
                {
                    x--;
                }
            }
            public void MoveRight()
            {
                if (x < playGroundWidth - 2)
                {
                    x++;
                }
            }
            public void Print(bool hit = false)
            {
                Console.SetCursorPosition(x, Console.WindowHeight - 1);
                Console.ForegroundColor = hit ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write(body);
            }
            public bool Overlap(Rock r)
            {
                if (Console.WindowHeight - 1 == r.y)
                {
                    if (x == r.x || x + 1 == r.x || x + 2 == r.x)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public class Rock
        {
            private char body;
            public int x, y;
            public ConsoleColor colour;
            private ConsoleColor GetRandomConsoleColor()
            {
                int r = rand.Next(3);
                switch (r)
                {
                    case 0: return ConsoleColor.White;
                    case 1: return ConsoleColor.Red;
                    case 2: return ConsoleColor.Cyan;
                    case 3: return ConsoleColor.Green;
                    default: return ConsoleColor.Black;
                }
            }
            public Rock()
            {
                body = r[rand.Next(r.Length)];
                x = rand.Next(playGroundWidth);
                y = 0;
                colour = GetRandomConsoleColor();
            }
            public bool MoveDown()
            {
                if (y < Console.WindowHeight - 1)
                {
                    y++;
                    return true;
                }
                return false;
            }
            public void Print()
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = colour;
                Console.Write(body);
            }
        }
        static void Initialisation()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.Title = "Falling Rocks";
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth = 50;
            rocks = new List<Rock>();
        }

        static void Main()
        {
            Initialisation();
            Dwarf dwarf = Dwarf.GetInstance();
            List<Rock> removeObsoletes;
            bool hit = false;
            ConsoleKeyInfo pressedKey;
            while (true)
            {
                for (int i = 0, count = 1; i < count; i++)
                {
                    rocks.Add(new Rock());
                }

                while (Console.KeyAvailable)
                {
                    pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        dwarf.MoveLeft();
                    }
                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        dwarf.MoveRight();
                    }
                }
                removeObsoletes = new List<Rock>();
                hit = false;
                foreach (Rock rock in rocks)
                {
                    if (!rock.MoveDown())
                    {
                        removeObsoletes.Add(rock);
                    }
                    if (dwarf.Overlap(rock))
                    {
                        hit = true;
                        Console.Beep();

                        Console.Out.WriteLine("GAME OVER !!!");
                        Environment.Exit(0);

                    }
                }
                Console.Clear();
                foreach (Rock old in removeObsoletes)
                {
                    rocks.Remove(old);
                }
                if (hit)
                {
                    rocks.Clear();
                }

                foreach (Rock rock in rocks)
                {
                    rock.Print();
                }
                dwarf.Print(hit);

                Thread.Sleep(150);
            }
        }
    }
}