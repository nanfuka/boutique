using Microsoft.EntityFrameworkCore;
using Myboutique.Models;

namespace Myboutique.Data
{
    public class MyBoutiqueContext : DbContext
    {
        public MyBoutiqueContext(DbContextOptions<MyBoutiqueContext> opt) : base(opt){

        }
       public DbSet<Myboutiques> mayBoutique{
           get; set;
       }

    }
}