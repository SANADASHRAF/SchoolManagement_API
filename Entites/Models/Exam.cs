using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Exam
    {
       public int Id { get; set; }
       public string Name { get; set; }


        [ForeignKey(nameof(SubjectId))]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }



        [ForeignKey(nameof(TeacherId))]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
