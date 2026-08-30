using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_2.Entities
{
    [Index(nameof(CountryID), IsUnique = true)]
    public class City
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        [ForeignKey(nameof(Country))]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}
