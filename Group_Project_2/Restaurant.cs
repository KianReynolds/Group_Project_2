using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_2
{
    internal class Restaurant
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Restaurant(string name, string location, CuisineType cuisine)
        {
            Name = name;
            Location = location;
            Cuisine = cuisine;
            MenuItems = new List<MenuItem>();
            Reservations = new List<Reservation>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }

        
        public void RemoveMenuItem(MenuItem menuItem)
        {
            MenuItems.Remove(menuItem);
        }

        public void DisplayMenu()
        {
            Console.WriteLine($"Menu for {Name} ({Cuisine} cuisine):");
            foreach (var menuItem in MenuItems)
            {
                Console.WriteLine($"{menuItem.Name} - {menuItem.Description} - ${menuItem.Price}");
            }
        }

        
        public void MakeReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
            Console.WriteLine($"Reservation made for {reservation.NumberOfPeople} people on {reservation.Date} at {reservation.Time}.");
        }

        
        public void CancelReservation(Reservation reservation)
        {
            Reservations.Remove(reservation);
            Console.WriteLine($"Reservation canceled for {reservation.NumberOfPeople} people on {reservation.Date} at {reservation.Time}.");
        }
    }

    
    public enum CuisineType
    {
        Italian,
        French,
        Mexican,
        Japanese,
        American,
        Other
    }

   
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    
    public class Reservation
    {
        public int NumberOfPeople { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
    }


}
