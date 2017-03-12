using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewDawn.Core.Models.Entities
{
    [Table("Documents")]
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string Id { get; set; }
        [Required]
        private ApplicationUser Student { get; set; }
        [Required]
        private Institution Institution { get; set; }
        [Required]
        private string Name { get; set; }
        [Required]
        private string Description { get; set; }
    }
}