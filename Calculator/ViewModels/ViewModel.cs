using Calculator.Commands;
using Calculator.UserControls.CalcButtons;
using Calculator.Utilities.Methods;
using System.ComponentModel;

namespace Calculator.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            InputCommand.PropertyChanged += (sender, e) =>
            {
                Result = ((InputCommand)sender!).Result.ToString();
                OnPropertyChanged(nameof(InputCommand.Result));
            };
            ClearEntryCommand.PropertyChanged += (sender, e) =>
            {
                Result = ((ClearEntryCommand)sender!).Result.ToString();
                OnPropertyChanged(nameof(InputCommand.Result));
            };
        }

        public InputCommand InputCommand { get; set; } = new InputCommand();
        public ClearEntryCommand ClearEntryCommand { get; set; } = new ClearEntryCommand();

        private string _valueLeft = string.Empty;
        public string ValueLeft
        {
            get => _valueLeft;
            set
            {
                _valueLeft = value;
                OnPropertyChanged(nameof(ValueLeft));
            }
        }

        public string Result { get; set; } = decimal.Zero.ToString();

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
