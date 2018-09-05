using System;
using System.Windows.Input;

namespace WPFNotepad
{
    public class Relay_Command : ICommand
    {
        readonly Action execute;
        readonly Func<bool> canExecute;

        public Relay_Command(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new NullReferenceException("execute");

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public Relay_Command(Action execute) : this(execute, null) { }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter) => canExecute == null ? true : canExecute();
        

        public void Execute(object parameter) => execute.Invoke();
        
    }
}
