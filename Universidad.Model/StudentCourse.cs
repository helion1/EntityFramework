using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    public class StudentCourse {
        public StudentCourse() {
        }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}
