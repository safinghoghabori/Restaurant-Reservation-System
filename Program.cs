internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Select your role: 1. Restaurant Owner 2. Customer -> ");
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
                Console.Write("10. Exit ------- ");
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
                    default:
                        Console.WriteLine("Kindly choose the correct option.");
                        break;
                }
            }
        }
        else 
        {
            
        }
    }
}