using Calculator.Commands.Interfaces;
using Calculator.UserControls.CalcButtons;
using System.ComponentModel;

namespace Calculator.Commands
{
    public class ClearEntryCommand : ICommand, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ButtonTextEnum BeforeClickButton { get; set; } = ButtonTextEnum.ClearEntry;
        public string Result { get; set; } = decimal.Zero.ToString();
        public string FormalEqual { get; set; } = string.Empty;
        public string ResultEqual { get; set; } = decimal.Zero.ToString();

        public void Execute(object? param)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}
