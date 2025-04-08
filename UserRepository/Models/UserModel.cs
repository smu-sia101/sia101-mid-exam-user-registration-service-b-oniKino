using SQLite;

namespace Exam.UserManager.Repository.Models
{
    public class UserModel
    {
        [PrimaryKey]
        public required string Id { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string FirstName { get; set; }
        public required string Lastname { get; set; }
        public bool IsActive { get; set; }
    }
}
