namespace ConstructionProjectManager.Client.Models
{
    public class Project
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public Status? Status { get; set; }

        public User? ProjectManager { get; set; }
        public List<TaskProject>? TaskProjects { get; set; }
    }
}
