using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;

namespace PMS.Models
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions options) : base(options)
        {
        } 
        public DbSet <Pet> PetsInfo{ get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
