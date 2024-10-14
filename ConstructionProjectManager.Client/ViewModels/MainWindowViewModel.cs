using ConstructionProjectManager.Client.Infrastructure;
using ConstructionProjectManager.Client.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecute(object parameter) => true;
        private void OnCloseApplicationCommandExecuted(object parameter) => Application.Current.Shutdown();

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
        }
    }
}
