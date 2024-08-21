public class Restaurant
{
    public string Name { get; set; }
    public List<Table> Tables { get; set; }
    public List<Customer> Customers {get;set;}
    public List<Reservation> Reservations {get;set;}

    public static int NumberOfTables = 0;

    public Restaurant()
    {
        Tables = new List<Table>();
        Customers = new List<Customer>();
        Reservations = new List<Reservation>();
    }

    public void AddTable(Table table)
    {
        Tables.Add(table);
    }

    public void DisplayTables() {
        if(Tables.Count == 0) {
            Console.WriteLine("0 tables.");
            return;
        }

        Console.WriteLine("====Display Tables====");
        foreach(Table table in Tables) {
            Console.WriteLine(table);
        }
        Console.WriteLine();
    }

    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }
    public void AddReservation(Reservation reservation)
    {
        Reservations.Add(reservation);
    }
}



