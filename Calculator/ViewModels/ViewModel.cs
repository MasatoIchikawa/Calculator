using Calculator.Commands;
using Calculator.UserControls.CalcButtons;
using System.ComponentModel;

namespace Calculator.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            InputCommand.PropertyChanged += (sender, e) =>
            {
                var command = (InputCommand)sender!;
                Result = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                OnPropertyChanged(nameof(Result));
            };
            PlusCommand.PropertyChanged += (sender, e) =>
            {
                Symbol = "+";
                var command = (PlusCommand)sender!;
                ValueLeft = command.ValueLeft;
                Result = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                OnPropertyChanged(nameof(Result));
            };
            MinusCommand.PropertyChanged += (sender, e) =>
            {
                Symbol = "-";
                var command = (MinusCommand)sender!;
                ValueLeft = command.ValueLeft;
                Result = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                OnPropertyChanged(nameof(Result));
            };
            TimesCommand.PropertyChanged += (sender, e) =>
            {
                Symbol = "×";
                var command = (TimesCommand)sender!;
                ValueLeft = command.ValueLeft;
                Result = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                OnPropertyChanged(nameof(Result));
            };
            DividedByCommand.PropertyChanged += (sender, e) =>
            {
                Symbol = "÷";
                var command = (DividedByCommand)sender!;
                ValueLeft = command.ValueLeft;
                Result = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                OnPropertyChanged(nameof(Result));
            };
            EqualCommand.PropertyChanged += (sender, e) =>
            {
                ValueLeft = string.Empty;
                Symbol = string.Empty;
                Result = decimal.Zero.ToString();

                var command = (EqualCommand)sender!;
                _formalEqual = command.Formal;
                _resultEqual = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                OnPropertyChanged(nameof(EqualCommand.Result));
            };
            ClearEntryCommand.PropertyChanged += (sender, e) =>
            {
                var command = (ClearEntryCommand)sender!;
                Result = command.Result;
                _formalEqual = command.FormalEqual;
                _resultEqual = command.ResultEqual;
                OnPropertyChanged(nameof(Result));
            };
            ClearAllCommand.PropertyChanged += (sender, e) =>
            {
                var command = (ClearAllCommand)sender!;
                Symbol = string.Empty;
                ValueLeft = command.ValueLeft;
                Result = command.Result;
                _formalEqual = command.FormalEqual;
                _resultEqual = command.ResultEqual;
                BeforeClickButton = ButtonTextEnum.None;
                OnPropertyChanged(nameof(Result));
            };
        }

        public InputCommand InputCommand { get; set; } = new InputCommand();
        public PlusCommand PlusCommand { get; set; } = new PlusCommand();
        public MinusCommand MinusCommand { get; set; } = new MinusCommand();
        public TimesCommand TimesCommand { get; set; } = new TimesCommand();
        public DividedByCommand DividedByCommand { get; set; } = new DividedByCommand();
        public EqualCommand EqualCommand { get; set; } = new EqualCommand();
        public ClearEntryCommand ClearEntryCommand { get; set; } = new ClearEntryCommand();
        public ClearAllCommand ClearAllCommand { get; set; } = new ClearAllCommand();

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

        //private string _valueRight = string.Empty;
        //public string ValueRight
        //{
        //    get => _valueRight;
        //    set
        //    {
        //        _valueRight = value;
        //        OnPropertyChanged(nameof(ValueRight));
        //    }
        //}

        private string _formal = string.Empty;
        private string _formalEqual = string.Empty;
        public string Formal 
        {
            get
            {
                return BeforeClickButton == ButtonTextEnum.Equals ? _formalEqual : $"{ValueLeft} {Symbol}";
            }
            set
            {
                _formal = value;
                OnPropertyChanged(nameof(Formal));
            }
        }

        private string _result = decimal.Zero.ToString();
        private string _resultEqual = string.Empty;
        public string Result
        {
            get
            {
                return BeforeClickButton == ButtonTextEnum.Equals ? _resultEqual : _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public string Symbol { get; set; } = string.Empty;
        public ButtonTextEnum BeforeClickButton;

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
