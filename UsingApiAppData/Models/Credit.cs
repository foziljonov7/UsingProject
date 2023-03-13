using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingApiAppData.Models
{
    public class Credit
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public String FullName { get; set; }
        [Required]
        public int MaxCredit { get; set; }
        [Required]
        public int CreditId { get; set; }
        [Required]
        public int credit { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Lender { get; set; }
        [Required]
        public DateTime Time { get; set; }
    }
}
