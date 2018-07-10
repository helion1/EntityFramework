using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    class Student {
        public Student() {
        }

        public Student(int id, string firstName, string lastName) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj) {
            var student = obj as Student;
            return student != null &&
                   Id == student.Id &&
                   FirstName == student.FirstName &&
                   LastName == student.LastName;
        }

        public override int GetHashCode() {
            var hashCode = 1502931708;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            return hashCode;
        }
    }
}
