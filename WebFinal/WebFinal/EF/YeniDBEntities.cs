using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
//SqlConnection baglantı = new SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=WVO;User ID=sa");
namespace WebFinal.EF
{
    public class YeniDBEntities : DbContext
    {
        public YeniDBEntities()
        {
        }
        public YeniDBEntities(DbContextOptions<YeniDBEntities> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public DbSet<Models.Ders> Ders { get; set; }

    }



}