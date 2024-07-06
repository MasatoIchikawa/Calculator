using System.ComponentModel;

namespace Calculator.Commands
{
    public class ClearEntryCommand : ICommand, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Result { get; set; } = string.Empty;

        public void Execute(object? param)
        {
            Result = decimal.Zero.ToString();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}
