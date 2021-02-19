using System;
using System.Windows.Input;

namespace PaintPartner.Commands
{
    public class SimpleCommand<T> : ICommand
    {
        private readonly Action<T> myExecutionAction;
        private readonly Func<T, bool> myCanExecuteFunction;

        public SimpleCommand(Action<T> executionAction, Func<T, bool> canExecuteFunction)
        {
            myExecutionAction = executionAction;
            myCanExecuteFunction = canExecuteFunction;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (!IsValidParameter(parameter))
            {
                throw new ArgumentException("The argument has an invalid type.");
            }

            myExecutionAction.Invoke((T)parameter);
        }

        public bool CanExecute(object parameter)
        {
            if (!IsValidParameter(parameter))
            {
                throw new ArgumentException("The argument has an invalid type.");
            }

            bool canExecute = myCanExecuteFunction.Invoke((T)parameter);
            return canExecute;
        }

        public void RaiseCanExecuteChanged()
        {
            EventHandler handler = CanExecuteChanged;
            handler?.Invoke(this, EventArgs.Empty);
        }

        private static bool IsValidParameter(object parameter)
        {
            if (parameter is T)
            {
                return true;
            }

            if (parameter == null)
            {
                return !typeof(T).IsValueType;
            }

            return false;
        }
    }
}
