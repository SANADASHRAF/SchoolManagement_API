using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Img { get; set; }
        public DateTime JoinedDate { get; set; }
        public double Salary { get; set; }

        public IEnumerable<Exam> Exams { get; set; }
        public IEnumerable<Subject>subjects { get; set; }
        public IEnumerable<StudentTeacher>studentTeachers{ get; set; }

        [ForeignKey(nameof(SchoolId))]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}
