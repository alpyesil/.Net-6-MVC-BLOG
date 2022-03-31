using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.DataAccessLayer.Data
{
    public class PostTag
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public int PostId { get; set; }

        [Required(ErrorMessage = "Tag alanı boş bırakılamaz!")]
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DeletedAt { get; set; } = DateTime.Now;

        // ## Navigtaion
        public virtual Post Post { get; set; }


    }
}