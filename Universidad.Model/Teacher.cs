﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    public class Teacher {
        public Teacher() {
            this.Courses = new HashSet<Course>();
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
