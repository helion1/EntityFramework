﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    public class Subject {
        public Subject() {
        }

        public Subject(int id, string name) {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

       
    }
}
