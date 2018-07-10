using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Model {
    class StudentCourse {
        public StudentCourse() {
        }

        public StudentCourse(int student_Id, int course_Id) {
            Student_Id = student_Id;
            Course_Id = course_Id;
        }

        public int Student_Id { get; set; }
        public int Course_Id { get; set; }

        public override bool Equals(object obj) {
            var course = obj as StudentCourse;
            return course != null &&
                   Student_Id == course.Student_Id &&
                   Course_Id == course.Course_Id;
        }

        public override int GetHashCode() {
            var hashCode = 53526040;
            hashCode = hashCode * -1521134295 + Student_Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Course_Id.GetHashCode();
            return hashCode;
        }
    }
}
