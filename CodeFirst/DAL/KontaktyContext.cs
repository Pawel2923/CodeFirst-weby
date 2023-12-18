using CodeFirst.Models;
using System.Data.Entity;

namespace CodeFirst.DAL
{
    public class KontaktyContext : DbContext
    {
        public KontaktyContext() : base("KontaktyConnectionString")
        {
        }
        public DbSet<Kontakt> Kontakty { get; set; }
        public DbSet<Pytanie> Pytania { get; set; }
    }
}
