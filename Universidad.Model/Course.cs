using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    class Course {
        public Course() {
        }

        public Course(int id, int teacherId, int subjectId) {
            Id = id;
            TeacherId = teacherId;
            SubjectId = subjectId;
        }

        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }

        public override bool Equals(object obj) {
            var course = obj as Course;
            return course != null &&
                   Id == course.Id &&
                   TeacherId == course.TeacherId &&
                   SubjectId == course.SubjectId;
        }

        public override int GetHashCode() {
            var hashCode = 242133362;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + TeacherId.GetHashCode();
            hashCode = hashCode * -1521134295 + SubjectId.GetHashCode();
            return hashCode;
        }
    }
}
