using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingApiAppData.Models
{
    public class Kurs
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        [MaxLength(4)]
        public double MaxRaplec { get; set; }      
    }
}
