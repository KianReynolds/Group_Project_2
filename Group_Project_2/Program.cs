namespace Group_Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Restaurant myRestaurant = new Restaurant("Best Foods Sligo", "O'Connell St", CuisineType.Italian);

            
            myRestaurant.AddMenuItem(new MenuItem { Name = "Spaghetti Bolognese", Description = "Classic Italian pasta dish", Price = 12.99m });
            myRestaurant.AddMenuItem(new MenuItem { Name = "Margherita Pizza", Description = "Traditional pizza with tomato, mozzarella, and basil", Price = 14.99m });
            myRestaurant.AddMenuItem(new MenuItem { Name = "Tiramisu", Description = "Italian dessert with coffee-soaked ladyfingers and mascarpone", Price = 8.99m });

            
            myRestaurant.DisplayMenu();

            
            Reservation reservation1 = new Reservation { NumberOfPeople = 4, Date = DateTime.Now.Date.AddDays(3), Time = "19:30" };
            myRestaurant.MakeReservation(reservation1);

            Console.WriteLine("Current Reservations:");
            foreach (var reservation in myRestaurant.Reservations)
            {
                Console.WriteLine($"- {reservation.NumberOfPeople} people on {reservation.Date.ToShortDateString()} at {reservation.Time}");
            }

           
            myRestaurant.CancelReservation(reservation1);

           
            Console.WriteLine("\nUpdated Reservations:");
            foreach (var reservation in myRestaurant.Reservations)
            {
                Console.WriteLine($"- {reservation.NumberOfPeople} people on {reservation.Date.ToShortDateString()} at {reservation.Time}");
            }
        }
    }
}
    
