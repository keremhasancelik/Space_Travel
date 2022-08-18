using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class References
    {
        [Key]
        public int ReferencesId { get; set; }
        public string? Client { get; set; }
        public string? Image { get; set; }
        public string? Comment { get; set; }
        public bool Status { get; set; }
    }
}
