using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vldmr.DB
{
    public class Ms_Context : DbContext
    {
        string connection = "Server=192.168.49.180; Database=KZN1; user id=stud; Password=stud; TrustServerCertificate=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(connection);
        }
    
        public DbSet<User> Users { get; set; }
    
        public class User
        {
            [Key]
            public string Name { get; set; }  
            public string Password { get; set; }   
           
        }
    }
}
