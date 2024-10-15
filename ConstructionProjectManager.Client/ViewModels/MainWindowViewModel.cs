using ConstructionProjectManager.Client.Models;
using ConstructionProjectManager.Client.ViewModels.Base;
using System.Collections.ObjectModel;

namespace ConstructionProjectManager.Client.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        public ObservableCollection<User> Users { get; }

        private User _selectedUser;
        public User SelectedUser
        {
            get => _selectedUser;
            set => Set(ref _selectedUser, value);
        }

        private string _title = "Главная станица";
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        public MainWindowViewModel()
        {
            int project_index = 1;
            var projects = Enumerable.Range(1, 10).Select(i => new Project
            {
                Name = $"Проект {project_index++}",
                CreatedDate = DateTime.Now,
                CompletedDate = DateTime.Now + TimeSpan.FromDays(20),
            });

            var users = Enumerable.Range(1, 20).Select(i => new User
            {
                Username = $"Сотрудник {i}",
                Projects = new ObservableCollection<Project>(projects)
            });

            Users = new ObservableCollection<User>(users);
        }
    }
}
