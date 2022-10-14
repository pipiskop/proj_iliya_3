Console.WriteLine("▒▒▒▒▒▒▒▒█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█\r\n▒▒▒▒▒▒▒█░▒▒▒▒▒▒▒▓▒▒▓▒▒▒▒▒▒▒░█\r\n▒▒▒▒▒▒▒█░▒▒▓▒▒▒▒▒▒▒▒▒▄▄▒▓▒▒░█░▄▄\r\n▒▒▄▀▀▄▄█░▒▒▒▒▒▒▓▒▒▒▒█░░▀▄▄▄▄▄▀░░█\r\n▒▒█░░░░█░▒▒▒▒▒▒▒▒▒▒▒█░░░░░░░░░░░█\r\n▒▒▒▀▀▄▄█░▒▒▒▒▓▒▒▒▓▒█░░░█▒░░░░█▒░░█\r\n▒▒▒▒▒▒▒█░▒▓▒▒▒▒▓▒▒▒█░░░░░░░▀░░░░░█\r\n▒▒▒▒▒▄▄█░▒▒▒▓▒▒▒▒▒▒▒█░░█▄▄█▄▄█░░█\r\n▒▒▒▒█░░░█▄▄▄▄▄▄▄▄▄▄█░█▄▄▄▄▄▄▄▄▄█\r\n▒▒▒▒█▄▄█░░█▄▄█░░░░░░█▄▄█░░█▄\r\n");
Console.WriteLine("для воиспроизведения мелодии нажмите 1\nдля игры на бибиби нажмите 2 ");
Double vibor = Convert.ToDouble(Console.ReadLine());
if (vibor == 1)
{
    Console.Beep(264, 125);
    Thread.Sleep(50);
    Console.Beep(264, 125);
    Thread.Sleep(25);
    Console.Beep(297, 500);
    Thread.Sleep(125);
    Console.Beep(264, 500);
    Thread.Sleep(25);
    Console.Beep(352, 500);
    Thread.Sleep(25);
    Console.Beep(330, 1000);
    Thread.Sleep(25);
    Console.Beep(264, 125);
    Thread.Sleep(50);
    Console.Beep(264, 125);
    Thread.Sleep(25);
    Console.Beep(297, 500);
    Thread.Sleep(25);
    Console.Beep(264, 500);
    Thread.Sleep(25);
    Console.Beep(396, 500);
    Thread.Sleep(25);
    Console.Beep(352, 1000);
    Thread.Sleep(50);
    Console.Beep(264, 125);
    Thread.Sleep(50);
    Console.Beep(264, 125);
    Thread.Sleep(25);
    Console.Beep(264, 500);
    Thread.Sleep(25);
    Console.Beep(440, 500);
    Thread.Sleep(25);
    Console.Beep(352, 250);
    Thread.Sleep(25);
    Console.Beep(352, 125);
    Thread.Sleep(25);
    Console.Beep(330, 500);
    Thread.Sleep(25);
    Console.Beep(297, 1000);
    Thread.Sleep(50);
    Console.Beep(466, 125);
    Thread.Sleep(250);
    Console.Beep(466, 125);
    Thread.Sleep(25);
    Console.Beep(440, 500);
    Thread.Sleep(25);
    Console.Beep(352, 500);
    Thread.Sleep(25);
    Console.Beep(396, 500);
    Thread.Sleep(25);
    Console.Beep(352, 1000);
}
if (vibor == 2)
    Console.WriteLine("поехали");
{
    int[] oct = Octave(1);
    while (true)
    {
        ConsoleKeyInfo ch = Console.ReadKey();
        if (ch.Key == ConsoleKey.F1)
        {
            oct = Octave(1);
            Console.WriteLine("\nоктава 1");
        }
        if (ch.Key == ConsoleKey.F2)
        {
            oct = Octave(2);
            Console.WriteLine("\nоктава 2");
        }
        if (ch.Key == ConsoleKey.F3)
        {
            oct = Octave(3);
            Console.WriteLine("\nоктава 3");
        }
        if (ch.Key == ConsoleKey.Q)
        {
            Sound(oct[0]);
        }
        if (ch.Key == ConsoleKey.A)
        {
            Sound(oct[1]);
        }
        if (ch.Key == ConsoleKey.W)
        {
            Sound(oct[2]);
        }
        if (ch.Key == ConsoleKey.S)
        {
            Sound(oct[3]);
        }
        if (ch.Key == ConsoleKey.E)
        {
            Sound(oct[4]);
        }
        if (ch.Key == ConsoleKey.R)
        {
            Sound(oct[5]);
        }
        if (ch.Key == ConsoleKey.D)
        {
            Sound(oct[6]);
        }
        if (ch.Key == ConsoleKey.T)
        {
            Sound(oct[7]);
        }
        if (ch.Key == ConsoleKey.F)
        {
            Sound(oct[8]);
        }
        if (ch.Key == ConsoleKey.Y)
        {
            Sound(oct[9]);
        }
        if (ch.Key == ConsoleKey.G)
        {
            Sound(oct[10]);
        }
        if (ch.Key == ConsoleKey.U)
        {
            Sound(oct[11]);
        }
    }
    static void Sound(int chastota)
    {
        Console.Beep(chastota, 500);
    }
    static int[] Octave(int octave)
    {
        int[] octave3 = { 34, 51, 68, 85, 102, 119, 136, 153, 170, 187, 204, 221 };
        int[] octave1 = { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
        int[] octave2 = { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
        if (octave == 2)
        {
            return octave2;
        }
        if (octave == 3)
        {
            return octave3;
        }
        return octave1;
    }
}
