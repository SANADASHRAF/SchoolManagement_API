using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public  string Img { get; set; }
        public DateTime JoinedDate { get; set; }



       
        public IEnumerable<Marks> marks { get; set; }
        public IEnumerable<StudentTeacher> studentTeachers { get; set; }
        public IEnumerable<StudentSubject>studentSubjects { get; set; }

        [ForeignKey(nameof(AcademicYear))]
        public  int AcademicYearId { get; set; }
        public virtual AcademicYear AcademicYear { get; set; }




        [ForeignKey(nameof(FatherId))]
        public int FatherId { get; set; }
        public virtual Father Father { get; set; }



        [ForeignKey(nameof(SchoolId))]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }

    }
}
