using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityModelsMigrationService.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string FullName { get; set; }
        [EmailAddress]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "please enter correct address")]
        public string Email { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
    }
}
