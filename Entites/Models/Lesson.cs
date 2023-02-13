using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string AttachMent { get; set; }



        [ForeignKey(nameof(SubjectId))]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
