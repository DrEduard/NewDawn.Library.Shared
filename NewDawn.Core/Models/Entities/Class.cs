using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewDawn.Core.Models.Entities
{
    [Table("Classes")]
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string Id { get; set; }

        [Required]
        private string Name { get; set; }
        [Required]
        private DateTime DateOfCreationUTC { get; set; }
        [Required]
        private string Details { get; set; }
        [Required]
        private Field Field { get; set; }
        [Required]
        private double MinimumPassingGrade { get; set; }
        private Class Related { get; set; }
    }
}