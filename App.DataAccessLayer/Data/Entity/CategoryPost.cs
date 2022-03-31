namespace App.DataAccessLayer.Data.Entity
{
    public class CategoryPost
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public int CategoryId { get; set; }

        // Navigation

        public Category Category { get; set; }

        public Post Post { get; set; }
    }
}