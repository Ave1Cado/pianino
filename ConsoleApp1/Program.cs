using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа пианино. Для выхода нажмите Escape.");

        int[] firstOctave = new int[] { 261, 293, 329, 349, 392, 440, 493 };
        int[] secondOctave = new int[] { 523, 587, 659, 698, 783, 880, 987 };
        int[] thirdOctave = new int[] { 1046, 1175, 1319, 1397, 1568, 1760, 1975 };

        int currentOctave = 1;
        int[] currentOctaveNotes = secondOctave;

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
                break;
            else if (keyInfo.Key == ConsoleKey.F1)
                currentOctaveNotes = firstOctave;
            else if (keyInfo.Key == ConsoleKey.F2)
                currentOctaveNotes = secondOctave;
            else if (keyInfo.Key == ConsoleKey.F3)
                currentOctaveNotes = thirdOctave;
            else
            {
                int noteIndex = Array.IndexOf(validKeys, keyInfo.Key);
                if (noteIndex >= 0)
                {
                    int frequency = currentOctaveNotes[noteIndex];
                    Console.Beep(frequency, 100);
                }
            }
        }
    }

    static ConsoleKey[] validKeys = new ConsoleKey[]
    {
ConsoleKey.A, ConsoleKey.S, ConsoleKey.D, ConsoleKey.F, ConsoleKey.G, ConsoleKey.H, ConsoleKey.J
    };
}