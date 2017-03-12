using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewDawn.Core.Models.Entities
{
    [Table("Semesters")]
    public class Semester
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string Id { get; set; }
    
        [Required]
        private DateTime StartDateUTC { get; set; }
        [Required]
        private DateTime EndDateUTC { get; set; }

        [Required]
        private Institution Institution { get; set; }
    }
}