﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DTO
{
    public class LSH
    {
        [Key]
        public int ID_Lop { get; set; }
        public string NameLop { get; set; }
        public ICollection<SV> SVs { get; set; }
        public LSH()
        {
            SVs = new HashSet<SV>();
        }
    }
}
