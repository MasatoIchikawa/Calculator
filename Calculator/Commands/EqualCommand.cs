using Calculator.Commands.Interfaces;
using Calculator.UserControls.CalcButtons;
using Calculator.Utilities.Methods;
using Calculator.ViewModels;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Calculator.Commands
{
    public class EqualCommand : ICommand, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ButtonTextEnum BeforeClickButton { get; set; } = ButtonTextEnum.None;
        public string Formal { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;

        public void Execute(object? param)
        {
            var vm = param as ViewModel;
            if (vm == null) return;
            if (vm.BeforeClickButton == ButtonTextEnum.Equals) return;

            switch (vm.Symbol)
            {
                case "+":
                    var plus = new PlusCommand();
                    plus.Execute(vm);
                    Result = plus.Result;
                    break;
            }

            Formal = $"{vm.ValueLeft} {vm.Symbol} {vm.Result} =";
            BeforeClickButton = ButtonTextEnum.Equals;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}
