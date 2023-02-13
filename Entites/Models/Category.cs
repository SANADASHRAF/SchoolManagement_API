﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }

        public IEnumerable<Subject> Subjects { get; set; }
    }
}
