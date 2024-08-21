
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a new restaurant
        var restaurant = new Restaurant
        {
            Name = "Gourmet Delight"
        };

        // Add some tables
        var vipTable1 = new VipTable
        {
            TableId = 1,
            Capacity = 4,
            Cost = 100,
            IsReserved = false,
            SpecialService = "Free Champagne"
        };

        var standardTable1 = new StandardTable
        {
            TableId = 2,
            Capacity = 2,
            Cost = 50,
            IsReserved = false,
            NearWindow = true
        };

        restaurant.AddTable(vipTable1);
        restaurant.AddTable(standardTable1);

        // Add some customers
        var customer1 = new Customer
        {
            CustomerId = 1,
            Name = "Alice Smith",
            PhoneNumber = "123-456-7890",
            Age = 30,
            Gender = "Female"
        };

        var customer2 = new Customer
        {
            CustomerId = 2,
            Name = "Bob Johnson",
            PhoneNumber = "098-765-4321",
            Age = 40,
            Gender = "Male"
        };

        restaurant.AddCustomer(customer1);
        restaurant.AddCustomer(customer2);

        // Make some reservations
        try
        {
            var reservation1 = new Reservation
            {
                Reservationid = 1,
                Datetime = new DateTime(2024, 8, 21, 19, 0, 0),
                Customer = customer1,
                Table = vipTable1
            };

            restaurant.AddReservation(reservation1);

            // Attempt to double-book the same customer at the same time
            var reservation2 = new Reservation
            {
                Reservationid = 2,
                Datetime = new DateTime(2024, 8, 21, 19, 0, 0),
                Customer = customer1,
                Table = standardTable1
            };

            restaurant.AddReservation(reservation2); // Should throw DoubleBookingException
        }
        catch (DoubleBookingException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InvalidReservationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (OverBookingException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Update a reservation
        try
        {
            var updatedReservation = new Reservation
            {
                Reservationid = 1,
                Datetime = new DateTime(2024, 8, 22, 19, 0, 0),
                Customer = customer2,
                Table = standardTable1
            };

            restaurant.UpdateReservation(1, updatedReservation);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error updating reservation: " + ex.Message);
        }

        // Cancel a reservation
        try
        {
            restaurant.CancelReservation(1);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error canceling reservation: " + ex.Message);
        }

        // Search reservations
        var reservationsOnDate = restaurant.SearchReservations(r => r.Datetime.Date == new DateTime(2024, 8, 21).Date);
        Console.WriteLine("Reservations on August 21, 2024:");
        foreach (var reservation in reservationsOnDate)
        {
            Console.WriteLine($"Reservation ID: {reservation.Reservationid}, Customer: {reservation.Customer.Name}, Table ID: {reservation.Table.TableId}, DateTime: {reservation.Datetime}");
        }
    }
}
