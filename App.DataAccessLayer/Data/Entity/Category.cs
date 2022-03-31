using App.DataAccessLayer.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.DataAccessLayer.Data
{
    public class Category
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Category başlığı boş bırakılamaz!")]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20, ErrorMessage = "Başlık maximum 20 karakter olabilir.")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "İçerik boş bırakılamaz!")]
        [Column(TypeName = "nvarchar")]
        [MaxLength(200, ErrorMessage = "Category açıklaması maximum 200 karakter olabilir.")]
        public string CategoryDescription { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime DeletedAt { get; set; } = DateTime.Now;

        // ## Navigtaion

        public ICollection<CategoryPost> CategoryPosts { get; set; } = new List<CategoryPost>();
    }
}