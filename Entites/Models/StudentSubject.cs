using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class StudentSubject
    {
        public int Id { get; set; }

        [ForeignKey(nameof(StudentId))]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
