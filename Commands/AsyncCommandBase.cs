using System.Threading.Tasks;

namespace CryptocurrenciesWPF.Commands
{
    public abstract class AsyncCommandBase : CommandBase
    {
        private bool _isExecuting = false;
        public bool IsExecuting 
        {
            get => _isExecuting;
            protected set
            {
                _isExecuting = value;
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !IsExecuting && base.CanExecute(parameter);
        }

        public override async void Execute(object? parameter)
        {
            IsExecuting = true;
            await ExecuteAsync(parameter);
            IsExecuting = false;
        }

        protected abstract Task ExecuteAsync(object? parameter);
    }
}
