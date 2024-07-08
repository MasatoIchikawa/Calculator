using Calculator.Commands.Interfaces;
using Calculator.UserControls.CalcButtons;
using Calculator.Utilities.Methods;
using Calculator.ViewModels;
using System.ComponentModel;

namespace Calculator.Commands
{
    public class DividedByCommand : ICommand, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ButtonTextEnum BeforeClickButton { get; set; } = ButtonTextEnum.None;
        public string FormalLeft { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;

        public void Execute(object? param)
        {
            try
            {
                var vm = param as ViewModel;
                if (vm == null) return;

                if (string.IsNullOrEmpty(vm.FormalLeft))
                {
                    FormalLeft = vm.Result;
                    Result = vm.Result;
                }
                else
                {
                    var inputA = vm.FormalLeft.TryDecimal();
                    var inputB = vm.Result.TryDecimal();
                    var calc = (inputA / inputB).ToRoundDown(5).ToString();
                    FormalLeft = calc;
                    Result = calc;
                }
            }
            catch (Exception)
            {
                FormalLeft = "Error";
                Result = "Error";
            }

            BeforeClickButton = ButtonTextEnum.DividedBy;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}
