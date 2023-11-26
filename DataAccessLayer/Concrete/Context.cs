using CorseEntity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MSI1S2I;database=CorseDb;integrated security=true");
            //optionsBuilder.UseSqlServer("workstation id=CorseDb.mssql.somee.com;packet size=4096;user id=kemaleaziz_SQLLogin_1;pwd=lo8u1474jh;data source=CorseDb.mssql.somee.com;persist security info=False;initial catalog=CorseDb");


        }

        public DbSet<Evaluation> Evaluations { get; set; }

        public DbSet<GroupAbout> GroupAbouts { get; set; }

        public DbSet<LanguageAbout> LanguageAbout { get; set; }

        public DbSet<Student> Students { get; set; }
       
        public DbSet<Teacher> Teachers { get; set; }
        
        public DbSet<Admin> Admins { get; set; }
      
        public DbSet<Schedule> Schedules { get; set; }
        
        public DbSet<Exam> Exams { get; set; }
       
       

    }
}
