using System;
namespace MISA.Infrastructure.Context
{
	public class DbContext :DbContext
	{
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=127.0.0.1; Port=3306; Database = MISA.NTAQ; User Id = root; Password = 1232456";
            optionsBuilder.UseMySql(connectionString);
        }
    }
}

