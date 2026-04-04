using System;
using System.Windows.Input;

namespace CVCloudApp.UI.ViewModels;

/// <summary>Minimal ICommand implementation that delegates execute and canExecute to supplied delegates.</summary>
public class RelayCommand : ICommand
{
    private readonly Action _execute;
    private readonly Func<bool>? _canExecute;

    public RelayCommand(Action execute, Func<bool>? canExecute = null)
    {
        _execute    = execute;
        _canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged;

    /// <summary>Returns true if no canExecute predicate was supplied, or the predicate returns true.</summary>
    public bool CanExecute(object? parameter) => _canExecute?.Invoke() ?? true;

    /// <summary>Invokes the execute delegate.</summary>
    public void Execute(object? parameter) => _execute();

    /// <summary>Forces all bound controls to re-query CanExecute.</summary>
    public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}
