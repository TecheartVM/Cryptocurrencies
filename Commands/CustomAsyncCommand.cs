using System;
using System.Threading.Tasks;

namespace CryptocurrenciesWPF.Commands
{
    public class CustomAsyncCommand : AsyncCommandBase
    {
        private readonly Func<Task> _task;

        public CustomAsyncCommand(Func<Task> task)
        {
            _task = task;
        }

        protected override async Task ExecuteAsync(object? parameter)
        {
             await _task();
        }
    }
}
