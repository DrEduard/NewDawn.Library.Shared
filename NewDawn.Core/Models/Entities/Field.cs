using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewDawn.Core.Models.Entities
{
    [Table("Fields")]
    internal class Field
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string Id { get; set; }

        [Required]
        private string Name { get; set; }
    }
}