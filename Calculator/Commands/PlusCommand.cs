using Calculator.Commands.Interfaces;
using Calculator.UserControls.CalcButtons;
using Calculator.Utilities.Methods;
using Calculator.ViewModels;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Calculator.Commands
{
    public class PlusCommand : ICommand, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ButtonTextEnum BeforeClickButton { get; set; } = ButtonTextEnum.None;
        public string ValueLeft { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;

        public void Execute(object? param)
        {
            var vm = param as ViewModel;
            if (vm == null) return;


            BeforeClickButton = ButtonTextEnum.Plus;
            decimal inputA = vm.ValueLeft.TryDecimal();
            decimal inputB = vm.Result.TryDecimal();
            ValueLeft = (inputA + inputB).ToString();
            Result = (inputA + inputB).ToString();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}
