﻿using ConstructionProjectManager.Client.Infrastructure.Commands.Base;

namespace ConstructionProjectManager.Client.Infrastructure.Commands
{
    internal class RelayCommand : Command
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _canExecute = CanExecute;
        }

        public override bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;
        public override void Execute(object? parameter)
        {
            if (!CanExecute(parameter)) return;
            _execute(parameter);
        }
    }
}
