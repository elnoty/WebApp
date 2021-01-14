using System;
using System.Data.Entity;
using System.Linq;

namespace MVCday4.Models
{
    public class ITIContext : DbContext
    {
        // Your context has been configured to use a 'ITIContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVCday4.Models.ITIContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ITIContext' 
        // connection string in the application configuration file.
        public ITIContext()
            : base("name=ITIContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Department> Department { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}