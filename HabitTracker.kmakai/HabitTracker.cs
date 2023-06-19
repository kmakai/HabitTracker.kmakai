using Microsoft.Data.Sqlite;

namespace HabitTracker.kmakai;

public class HabitTracker
{
    private List<string> _habitsList { get; set; } = new List<string>();
    private string? _connectionString { get; set; } = @"Data Source=Habit_Tracker.db";
    
    public void start()
    {
        while (true)
        {
            TrackerMenu.MainMenu();
            string option = TrackerMenu.GetOption();
        }
    }
    public void AddHabit()
    {
        string habit = TrackerMenu.GetOption("Please enter the habit you want to add use underscore ( _ ) for spaces: ");
        string UnitOfMeasurement = TrackerMenu.GetOption("Please enter the unit of measurement all will: ");


        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var tableCommand = connection.CreateCommand();

            tableCommand.CommandText = @$"CREATE TABLE IF NOT EXISTS {habit} (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Date TEXT,
                                            {UnitOfMeasurement} Double,
                                        )";

            tableCommand.ExecuteNonQuery();

            connection.Close();
        }

        _habitsList.Add(habit);
    }
}
