using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }



        public IEnumerable<Lesson>lessons { get; set; }
        public IEnumerable<Marks>marks { get; set; }
        public IEnumerable<Exam> Exams { get; set; }
        public IEnumerable<StudentSubject>studentSubjects { get; set; }

        [ForeignKey(nameof(AcademicYear))]
        public int AcademicYearId { get; set; }
        public virtual AcademicYear AcademicYear { get; set; }


        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


        [ForeignKey(nameof(TeacherId))]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
