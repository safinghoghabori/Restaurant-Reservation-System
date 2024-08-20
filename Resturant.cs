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
    public void UpdateReservation(int reservationId, Reservation updatedReservation)
    {
        var reservation = Reservations.FirstOrDefault(r => r.Reservationid == reservationId);
        if (reservation != null)
        {
            reservation.Customer = updatedReservation.Customer;
            reservation.Table = updatedReservation.Table;
            reservation.Datetime = updatedReservation.Datetime;
        }
    }

    public void CancelReservation(int reservationId)
    {
        var reservation = Reservations.FirstOrDefault(r => r.Reservationid == reservationId);
        if (reservation != null)
        {
            Reservations.Remove(reservation);
        }
    }

    public List<Reservation> SearchReservations(Func<Reservation, bool> predicate)
    {
        return Reservations.Where(predicate).ToList();
    }

}




