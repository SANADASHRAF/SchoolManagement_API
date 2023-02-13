using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class AcademicYear
    {
        public int Id { get; set; }
        public string AcademicYears { get; set; }
        public DateTime Year { get; set; }

        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }

    }
}
