using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    public class UniversidadEntity : DbContext{
        public UniversidadEntity()
           // : base("name=UniversidadEntity") 
           {
            Database.SetInitializer(new CreateDatabaseIfNotExists<UniversidadEntity>());
        }


        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }

}
