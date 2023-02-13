using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class StudentTeacher
    {
        public int Id { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        [ForeignKey(nameof(StudentId))]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
