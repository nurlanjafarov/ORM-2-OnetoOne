using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_2.Entities
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public virtual City City { get; set; }
        
    }
}
