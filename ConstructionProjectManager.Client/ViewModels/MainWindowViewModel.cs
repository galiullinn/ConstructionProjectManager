using ConstructionProjectManager.Client.Infrastructure.Commands;
using ConstructionProjectManager.Client.Models;
using ConstructionProjectManager.Client.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

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

        public ICommand CreateUserCommand { get; }
        private bool CanCreateUserCommandExecute(object p) => true;
        private void OnCreateUserCommandExecuted(object p)
        {
            var userIndex = Users.Count + 1;

            var newUser = new User
            {
                Username = $"Сотрудник {userIndex}",
                Projects = new ObservableCollection<Project>()
            };

            Users.Add(newUser);
        }

        public ICommand DeleteUserCommand { get; }
        public bool CanDeleteUserCommandExecute(object p) => p is User user && Users.Contains(user);
        public void OnDeleteUserCommandExecuted(object p)
        {
            if (!(p is User user)) return;
            Users.Remove(user);
        }

        public MainWindowViewModel()
        {
            CreateUserCommand = new RelayCommand(OnCreateUserCommandExecuted, CanCreateUserCommandExecute);
            DeleteUserCommand = new RelayCommand(OnDeleteUserCommandExecuted, CanDeleteUserCommandExecute);

            int projectIndex = 1;
            var projects = Enumerable.Range(1, 10).Select(i => new Project
            {
                Name = $"Проект {projectIndex++}",
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
