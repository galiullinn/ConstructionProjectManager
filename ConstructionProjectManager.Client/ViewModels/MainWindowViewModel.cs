using ConstructionProjectManager.Client.Infrastructure.Commands;
using ConstructionProjectManager.Client.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace ConstructionProjectManager.Client.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _title = "Главная станица";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
    }
}
