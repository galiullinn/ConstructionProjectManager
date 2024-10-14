namespace ConstructionProjectManager.Client.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<TaskProject> TaskProjects { get; set; }
    }
}
