using System;
using System.Data.Entity;

namespace contactManager2.Models
{
    public class Contacts
    {

        public int Id { get; set; }

        public string Name { get; set; }

    }

    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class ContactDBContext : DbContext
    {
        public DbSet<Contacts> ContactList { get; set; }
    }


}