using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewDawn.Core.Models.Entities
{
    [Table("ProfClassAssoc")]
    public class ProfClassAssoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string Id { get; set; }
        [Required]
        private ApplicationUser Professor { get; set; }
        [Required]
        private Class Class { get; set; }
        [Required]
        private bool IsCoordinator { get; set; }

    }
}