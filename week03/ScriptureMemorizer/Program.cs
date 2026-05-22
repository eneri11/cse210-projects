using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // =========================================================
        // This program uses a library of scriptures instead of
        // only one scripture.
        // A random scripture was selected each time the program runs.
        // =========================================================

        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."
            ),

            new Scripture(
                new Reference("Moroni", 10, 32),
                "Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God."
            )
        };

        Random random = new Random();

        // Randomly select a scripture
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Continue until all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            // Display scripture
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine();

            // Quit option
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide random words
            scripture.HideRandomWords(3);
        }

        Console.Clear();

        // Final display
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}