namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Всего октав 4 , чтобы поменять октаву нажмите F2 или нажмите Escape , чтобы закончить");
            ConsoleKeyInfo start = Console.ReadKey();
            while (start.Key != ConsoleKey.Escape)
            {
                if (start.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("F5");
                    while (start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 0);
                    }
                }
                else if (start.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("F2");
                    while (start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 2);
                    }
                }
                else if (start.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("F3");
                    while (start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 3);
                    }
                }
                else if (start.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("F4");
                    while (start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.Escape)
                    {
                        start = key(start, 1);
                    }
                }
                else
                {
                    Console.WriteLine(" Такой октавы нету");
                    start = Console.ReadKey();
                }
            }
        }

        static int sound(int i, int j) 
        {
            int[,] arr = new int[4, 12] { { 523, 587, 659, 698, 784, 880, 987, 554, 622, 740, 830, 932, }, { 261, 293, 329, 349, 392, 440, 494, 277, 311, 370, 415, 366, }, { 65, 73, 82, 87, 98, 110, 123, 69, 78, 93, 103, 116 }, { 130, 146, 164, 174, 196, 220, 246, 138, 155, 185, 207, 233 } };
            return arr[i, j];
        }
        static ConsoleKeyInfo key(ConsoleKeyInfo start, int i) 
        {
            start = Console.ReadKey();
            if (start.Key == ConsoleKey.Q) //до
            {
                int N = sound(i, 0);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.W) // ре
            {
                int N = sound(i, 1);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.E) // ми
            {
                int N = sound(i, 2);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.R) // фа
            {
                int N = sound(i, 3);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.T) // соль
            {
                int N = sound(i, 4);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.Y) // ля
            {
                int N = sound(i, 5);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.U) // си
            {
                int N = sound(i, 6);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D2)
            {
                int N = sound(i, 7);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D3)
            {
                int N = sound(i, 8);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D5)
            {
                int N = sound(i, 9);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D6)
            {
                int N = sound(i, 10);
                sound2(N);
            }
            else if (start.Key == ConsoleKey.D7)
            {
                int N = sound(i, 11);
                sound2(N);
            }
            else if (start.Key != ConsoleKey.F2 && start.Key != ConsoleKey.F3 && start.Key != ConsoleKey.F5 && start.Key != ConsoleKey.F4 && start.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Такой клавиши нету");
            }
            return start;
        }
        public static void sound2(int N)
        {
            Console.Clear();
            Console.Beep(N, 200);
        }
    }
}