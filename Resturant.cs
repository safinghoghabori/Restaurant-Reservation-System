public class Restaurant
{
    public string Name { get; set; }
    public List<Table> Tables { get; set; }
    public List<Customer> Customers{get;set;}
    public List<Reservation>Reservations{get;set;}

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
     public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public void AddReservation(Reservation reservation)
    {
        Reservations.Add(reservation);
    }
}



