using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    class Subject {
        public Subject() {
        }

        public Subject(int id, string name) {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj) {
            var subject = obj as Subject;
            return subject != null &&
                   Id == subject.Id &&
                   Name == subject.Name;
        }

        public override int GetHashCode() {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
