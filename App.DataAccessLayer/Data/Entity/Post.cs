using App.DataAccessLayer.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.DataAccessLayer.Data
{
    public class Post
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required(ErrorMessage = "Post başlığı boş bırakılamaz!")]
        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100, ErrorMessage = "Başlık maximum 100 karakter olabilir.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "İçerik boş bırakılamaz!")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Content { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DataType(DataType.Url)]
        public string? Media { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime DeletedAt { get; set; } = DateTime.Now;

        // ## Navigtaion
        public virtual User User { get; set; }

        public ICollection<Category> Categories { get; set; } = new List<Category>();

        public ICollection<PostComment> PostComments { get; set; } = new List<PostComment>();

        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();

        public ICollection<CategoryPost> CategoryPosts { get; set; } = new List<CategoryPost>();
    }
}