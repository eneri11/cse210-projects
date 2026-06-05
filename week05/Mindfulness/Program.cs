using System;

// Creativity:
// 1. Reflection prompts and questions do not repeat until all prompts have been used.
// 2. Listing prompts do not repeat until all prompts have been used.
// 3. Activity completion counter is displayed when the user exits.

class Program
{
    static void Main(string[] args)
    {
        int completedActivities = 0;
        int choice = 0;

        while (choice != 4)
        {
            try
            {
                Console.Clear();
            }
            catch
            {
                // Ignore Console.Clear errors
            }

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = 0;
            }

            switch (choice)
            {
                case 1:
                    new BreathingActivity().Run();
                    completedActivities++;
                    break;

                case 2:
                    new ReflectionActivity().Run();
                    completedActivities++;
                    break;

                case 3:
                    new ListingActivity().Run();
                    completedActivities++;
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine(
                        $"You completed {completedActivities} mindfulness activities this session.");
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}