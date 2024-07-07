using Calculator.Commands.Interfaces;
using Calculator.UserControls.CalcButtons;
using Calculator.Utilities.Methods;
using Calculator.ViewModels;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Calculator.Commands
{
    public class MinusCommand : ICommand, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ButtonTextEnum BeforeClickButton { get; set; } = ButtonTextEnum.None;
        public string ValueLeft { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;

        public void Execute(object? param)
        {
            var vm = param as ViewModel;
            if (vm == null) return;

            if (string.IsNullOrEmpty(vm.ValueLeft))
            {
                ValueLeft = vm.Result;
                Result = vm.Result;
            }
            else
            {
                var inputA = vm.ValueLeft.TryDecimal();
                var inputB = vm.Result.TryDecimal();
                var calc = (inputA - inputB).ToString();
                ValueLeft = calc;
                Result = calc;
            }
            BeforeClickButton = ButtonTextEnum.Minus;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}
