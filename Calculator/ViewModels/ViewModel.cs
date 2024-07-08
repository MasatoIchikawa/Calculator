using Calculator.Commands;
using Calculator.UserControls.CalcButtons;
using Calculator.Utilities.Methods;
using System.ComponentModel;
using System.Diagnostics;

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
                _WriteLog(command.BeforeClickButton);
                OnPropertyChanged(nameof(Result));
            };
            PlusCommand.PropertyChanged += (sender, e) =>
            {

                var command = (PlusCommand)sender!;
                Symbol = command.BeforeClickButton.GetName();
                FormalLeft = command.FormalLeft;
                Result = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                _WriteLog(command.BeforeClickButton);
                OnPropertyChanged(nameof(Result));
            };
            MinusCommand.PropertyChanged += (sender, e) =>
            {
                var command = (MinusCommand)sender!;
                Symbol = command.BeforeClickButton.GetName();
                FormalLeft = command.FormalLeft;
                Result = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                _WriteLog(command.BeforeClickButton);
                OnPropertyChanged(nameof(Result));
            };
            TimesCommand.PropertyChanged += (sender, e) =>
            {
                var command = (TimesCommand)sender!;
                Symbol = command.BeforeClickButton.GetName();
                FormalLeft = command.FormalLeft;
                Result = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                _WriteLog(command.BeforeClickButton);
                OnPropertyChanged(nameof(Result));
            };
            DividedByCommand.PropertyChanged += (sender, e) =>
            {
                var command = (DividedByCommand)sender!;
                Symbol = command.BeforeClickButton.GetName();
                FormalLeft = command.FormalLeft;
                Result = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                _WriteLog(command.BeforeClickButton);
                OnPropertyChanged(nameof(Result));
            };
            EqualCommand.PropertyChanged += (sender, e) =>
            {
                FormalLeft = string.Empty;
                Symbol = string.Empty;
                Result = decimal.Zero.ToString();

                var command = (EqualCommand)sender!;
                _formalEqual = command.Formal;
                _resultEqual = command.Result;
                BeforeClickButton = command.BeforeClickButton;
                _WriteLog(command.BeforeClickButton);
                OnPropertyChanged(nameof(EqualCommand.Result));
            };
            ClearEntryCommand.PropertyChanged += (sender, e) =>
            {
                var command = (ClearEntryCommand)sender!;
                Result = command.Result;
                _formalEqual = command.FormalEqual;
                _resultEqual = command.ResultEqual;
                BeforeClickButton = command.BeforeClickButton;
                _WriteLog(command.BeforeClickButton);
                OnPropertyChanged(nameof(Result));
            };
            ClearAllCommand.PropertyChanged += (sender, e) =>
            {
                var command = (ClearAllCommand)sender!;
                Symbol = string.Empty;
                FormalLeft = command.ValueLeft;
                Result = command.Result;
                _formalEqual = command.FormalEqual;
                _resultEqual = command.ResultEqual;
                BeforeClickButton = command.BeforeClickButton;
                _WriteLog(command.BeforeClickButton);
                OnPropertyChanged(nameof(Result));
            };
        }

        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()!.DeclaringType);
        public InputCommand InputCommand { get; set; } = new InputCommand();
        public PlusCommand PlusCommand { get; set; } = new PlusCommand();
        public MinusCommand MinusCommand { get; set; } = new MinusCommand();
        public TimesCommand TimesCommand { get; set; } = new TimesCommand();
        public DividedByCommand DividedByCommand { get; set; } = new DividedByCommand();
        public EqualCommand EqualCommand { get; set; } = new EqualCommand();
        public ClearEntryCommand ClearEntryCommand { get; set; } = new ClearEntryCommand();
        public ClearAllCommand ClearAllCommand { get; set; } = new ClearAllCommand();

        private string _formalLeft = string.Empty;
        public string FormalLeft
        {
            get => _formalLeft;
            set
            {
                _formalLeft = value;
                OnPropertyChanged(nameof(_formalLeft));
            }
        }

        private string _formal = string.Empty;
        private string _formalEqual = string.Empty;
        public string Formal 
        {
            get
            {
                return BeforeClickButton == ButtonTextEnum.Equals ? _formalEqual : $"{FormalLeft} {Symbol}";
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

        public bool IsDebug =>
            #if DEBUG
                true;
            #else
                false;
            #endif

        private void _WriteLog(ButtonTextEnum button)
        {
            var text = $"{button.GetName()}をクリックしました。";
            if (IsDebug)
            {
                Debug.WriteLine(text);
            }
            else
            {
                _logger.Info(text);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
