internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Select your role: \n 1. Restaurant Owner \n 2. Customer -> ");
        int role = Convert.ToInt32(Console.ReadLine());

        if(role == 1) 
        {
            Console.Write("Enter restaurant name: ");
            string restaurantName = Console.ReadLine();
            Restaurant restaurant = new Restaurant();

            
            while(true) {
                Console.WriteLine("Select option you want to do: ");
                Console.WriteLine("1. Add tables");
                Console.WriteLine("2. Display all tables");
                Console.WriteLine("3. Check numbers of tables available");
                Console.WriteLine("4. Remove table");
                Console.Write("10. Exit -------> ");
                int option = Convert.ToInt32(Console.ReadLine());

                if(option == 10) 
                {
                    break;
                }

                switch(option) {
                    case 1: 
                        Console.Write("Enter table id = ");
                        int tableId = Convert.ToInt32(Console.ReadLine());    
                        Console.Write("capacity = ");
                        int capacity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("cost = ");
                        int cost = Convert.ToInt32(Console.ReadLine());
                        restaurant.AddTable(new Table() {TableId = tableId, Capacity = capacity, Cost = cost, IsReserved = false});
                        break;
                    case 2: 
                        restaurant.DisplayTables();
                        break;
                    case 3:
                        Console.WriteLine("\n====Display number of tables====");
                        Console.WriteLine($"Number of vacant tables = {Restaurant.NumberOfTables}");
                        break;
                    case 4: 
                        Console.Write("Enter table id to remove: ");
                        int tabId = Convert.ToInt32(Console.ReadLine());
                        string result = restaurant.RemoveTable(tabId);
                        Console.WriteLine($"\n{result}\n");
                        break;
                    default:
                        Console.WriteLine("\nKindly choose the correct option.\n");
                        break;
                }
            }
        }
        else 
        {
            
        }
    }
}