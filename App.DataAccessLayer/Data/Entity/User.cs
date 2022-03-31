using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.DataAccessLayer.Data
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz!")]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20, ErrorMessage = "Kullanıcı adı maximum 20 karakter olabilir.")]
        [MinLength(3, ErrorMessage = "Kullanıcı adı mimum 3 karakter olabilir.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz!")]
        [MaxLength(20, ErrorMessage = "Şifre maximum 20 karakter olabilir.")]
        [MinLength(5, ErrorMessage = "Şifre mimum 5 karakter olabilir.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz!")]
        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(50, ErrorMessage = "E-Posta Adresi maximum50 karakter olabilir.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DataType(DataType.Url)]
        public string? ProfileImagePath { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string Roles { get; set; }

        public bool IsActive { get; set; }

        // ## Navigtaion

        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<PostComment> PostComments { get; set; } = new List<PostComment>();
    }
}