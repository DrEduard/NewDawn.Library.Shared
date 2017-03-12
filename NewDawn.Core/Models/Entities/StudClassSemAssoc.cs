using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewDawn.Core.Models.Entities
{
    [Table("StudClassSemAssoc")]
    public class StudClassSemAssoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string Id { get; set; }

        [Required]
        private ApplicationUser Student { get; set; }
        [Required]
        private Class Class { get; set; }
        [Required]
        private Semester Semester { get; set; }
        private double Grade { get; set; }
        private bool PassStatus { get; set; }
        private DateTime GradeDate { get; set; }
        private StudClassSemAssoc InheritedFrom { get; set; }
        /// <summary>
        /// null or 0 if false and 1 if true
        /// </summary>
        private bool IsTransfer { get; set; }
    }
}