using Calculator.Commands.Interfaces;
using Calculator.UserControls.CalcButtons;
using Calculator.Utilities.Methods;
using Calculator.ViewModels;
using System.ComponentModel;

namespace Calculator.Commands
{
    public class InputCommand : ICommand, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ButtonTextEnum BeforeClickButton { get; set; } = ButtonTextEnum.None;
        public string Result { get; set; } = string.Empty;

        public void Execute(object? param)
        {
            Result = string.Empty;

            var tuple = param as Tuple<object, ViewModel>;
            if (tuple == null) return;

            var button = tuple.Item1 as CalcButton;
            if (button == null) return;

            var txtResult = tuple.Item2.Result;
            switch (tuple.Item2.BeforeClickButton)
            {
                case ButtonTextEnum.Plus:
                case ButtonTextEnum.Minus:
                case ButtonTextEnum.Times:
                case ButtonTextEnum.DividedBy:
                case ButtonTextEnum.Equals:
                    txtResult = string.Empty;
                    break;
            }

            BeforeClickButton = button.ButtonText;
            Result = button.ButtonText.GetName();

            if (button.ButtonText == ButtonTextEnum.DecimalPoint)
            {
                if (string.IsNullOrEmpty(txtResult)) Result = "0" + Result; //最初に.をクリックした際には0を先頭に追加する
                else if (txtResult.Contains('.')) Result = string.Empty; //既に.がある場合には新しく.は追加しない
            }

            if (txtResult.GetDecimalPointLength() >= 5) //小数点は5桁まで入力可能
            {
                Result = string.Empty;
            }

            if (txtResult == decimal.Zero.ToString() && button.ButtonText != ButtonTextEnum.DecimalPoint)
            {
                Result = Result; //結果値が0の場合は0を入力した値で上書きする
            }
            else
            {
                Result = txtResult + Result;
            }
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
        }
    }
}
