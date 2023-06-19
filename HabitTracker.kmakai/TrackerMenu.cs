namespace HabitTracker.kmakai;

public class TrackerMenu
{
    public static void MainMenu()
    {
        Console.WriteLine("Welcome to the Habit Tracker!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Add a habit");
        Console.WriteLine("2. Remove a habit");
        Console.WriteLine("3. Manage habits");
        Console.WriteLine("0. Exit");
    }

    public static void ManageHabitsMenu(List<string> list)
    {
        Console.WriteLine("Please select the habit:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {list[i]}");
        }

    }

    public static string GetOption(string? message = null)
    {
        if (message != null) Console.WriteLine(message);
        Console.Write("\nEnter your input: ");

        string? option = Console.ReadLine();

        while (option == null || option == "")
        {
            Console.WriteLine("Please enter a valid input!");
            Console.Write("\nEnter your input: ");
            option = Console.ReadLine();
        }

        return option;
    }
}


