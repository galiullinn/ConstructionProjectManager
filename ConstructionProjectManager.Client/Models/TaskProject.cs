namespace ConstructionProjectManager.Client.Models
{
    public class TaskProject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public Status Status { get; set; }

        public Project Project { get; set; }
        public User ProjectManager { get; set; }
        public ICollection<User> AssignmentUsers { get; set; } = [];
    }
}
