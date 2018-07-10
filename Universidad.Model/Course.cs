using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    public class Course {
        public Course() {
            this.Students = new HashSet<Student>();
        }
        
        public int Id { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}
