using System;

class Program
{
    static void Main(string[] args)
    {
        // - Added mood tracking for each journal entry
        // - Added extra custom prompts
        // - Added validation to prevent empty entries
        // - Added entry count display

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("===== Journal Menu =====");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");

            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine($"Prompt: {prompt}");

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                // Prevent empty entries
                if (response.Trim() == "")
                {
                    Console.WriteLine("Entry cannot be empty.");
                    continue;
                }

                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);

                Console.WriteLine("Entry added successfully.");
            }
            else if (choice == 2)
            {
                journal.DisplayAll();

                Console.WriteLine($"Total Entries: {journal._entries.Count}");
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);

                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);

                Console.WriteLine("Journal loaded successfully.");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}