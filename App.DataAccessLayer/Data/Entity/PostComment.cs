using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.DataAccessLayer.Data
{
    public class PostComment
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int PostId { get; set; }

        [Required(ErrorMessage = "Boş yorum atılamaz!")]
        [Column(TypeName = "nvarchar")]
        public string Comment { get; set; }

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
        public virtual User User { get; set; }


    }
}