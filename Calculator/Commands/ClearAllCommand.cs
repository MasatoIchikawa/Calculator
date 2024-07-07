using System.ComponentModel;
using Calculator.Commands.Interfaces;

namespace Calculator.Commands
{
    public class ClearAllCommand : ICommand, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string ValueLeft { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
        public string FormalEqual { get; set; } = string.Empty;
        public string ResultEqual { get; set; } = decimal.Zero.ToString();

        public void Execute(object? param)
        {
            ValueLeft = string.Empty;
            Result = decimal.Zero.ToString();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}
