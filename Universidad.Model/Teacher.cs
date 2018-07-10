using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    class Teacher {
        public Teacher() {
        }

        public Teacher(int id, string firstName, string lastName) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj) {
            var teacher = obj as Teacher;
            return teacher != null &&
                   Id == teacher.Id &&
                   FirstName == teacher.FirstName &&
                   LastName == teacher.LastName;
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
