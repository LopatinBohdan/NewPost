namespace NewPost.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Phonenumber { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int RoleId { get; set; }
        public virtual Role? UserRole { get; set; }
    }
}
