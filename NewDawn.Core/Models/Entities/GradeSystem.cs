using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewDawn.Core.Models.Entities
{
    [Table("GradeSystems")]
    public class GradeSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string Id { get; set; }
        [Required]
        private string Name { get; set; }
        [Required]
        private Country Country { get; set; }
        [Required]
        private string ConversionRule { get; set; }
    }
}