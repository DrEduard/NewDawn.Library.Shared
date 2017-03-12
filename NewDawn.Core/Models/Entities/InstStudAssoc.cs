using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewDawn.Core.Models.Entities
{
    [Table("InstStudentAssoc")]
    public class InstStudAssoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string Id { get; set; }
        [Required]
        private ApplicationUser Student { get; set; }
        [Required]
        private Institution Institution { get; set; }
        [Required]
        private DateTime DateOfEnrollmentUTC { get; set; }

       
        /// <summary>
        /// NULL if the student is still enrolled
        /// </summary>
        private DateTime DateOfGraduationUTC { get; set; }
    }
}