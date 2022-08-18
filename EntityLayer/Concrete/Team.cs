﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string? Keywords { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public string? Phone { get; set; }
        public bool Status { get; set; }
    }
}
