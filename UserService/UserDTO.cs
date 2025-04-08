namespace Exam.UserManager.Service
{
    public class UserDTO
    {
        public required string Id { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string FirstName { get; set; }
        public required string Lastname { get; set; }
        public bool IsActive { get; set; }
    }
}
