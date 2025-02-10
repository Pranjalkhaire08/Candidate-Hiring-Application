using HiringApp.Entities;
using HiringApp.Service_Layer;

public class Program
{
    public static void Main(string[] args)
    {
        HiringService service = new HiringService();

        while (true) // Main menu loop
        {
            Console.WriteLine("\nHiring Application Menu:");
            Console.WriteLine("1. Add Candidate");
            Console.WriteLine("2. Add Job Position");
            Console.WriteLine("3. Assign Candidate");
            // ... other menu options
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddCandidate(service);
                    break;
                case "2":
                    AddJobPosition(service);
                    break;
                case "3":
                    AssignCandidate(service);
                    break;
                // ... other cases
                case "0":
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    private static void AssignCandidate(HiringService service) => throw new NotImplementedException();

    private static void AddJobPosition(HiringService service)
    {
        throw new NotImplementedException();
    }

    // Example of AddCandidate method:
    private static void AddCandidate(HiringService service)
    {
        try
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            // ... (Get other candidate details)

            Candidate newCandidate = new Candidate
            {
                FirstName = firstName,
                // ... (Set other properties)
            };

            service.AddCandidate(newCandidate);
            Console.WriteLine("Candidate added successfully.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message); // Display error message
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message); // Generic error handling
        }
    }

    // ... (Implement other UI methods: AddJobPosition, AssignCandidate, etc.)
}