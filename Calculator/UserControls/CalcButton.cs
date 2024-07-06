using Calculator.Utilities.Attributes;
using Calculator.Utilities.Methods;
using System.ComponentModel;

namespace Calculator.UserControls
{
    public class CalcButton : Button
    {
        private ButtonTextEnum _buttonText;

        [Category("表示"), Browsable(true)]
        [Description("ボタンに表示する文字を指定します。")]
        public ButtonTextEnum ButtonText
        {
            get
            {
                return _buttonText;
            }
            set
            {
                Text = value.GetName();
                _buttonText = value;
            }
        }

        [Browsable(false)]
        public override string Text { get; set; } = string.Empty;

        public CalcButton()
        {
            FlatStyle = FlatStyle.Flat;
            Size = new Size(60, 40);
            Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonText = ButtonTextEnum.None;
        }

        public enum ButtonTextEnum
        {
            [Name("")]
            None,
            [Name("0")]
            Zero,
            [Name("1")]
            One,
            [Name("2")]
            Two,
            [Name("3")]
            Three,
            [Name("4")]
            Four,
            [Name("5")]
            Five,
            [Name("6")]
            Six,
            [Name("7")]
            Seven,
            [Name("8")]
            Eight,
            [Name("9")]
            Nine,
            [Name(" .")]
            DecimalPoint,
            [Name("＋")]
            Plus,
            [Name("-")]
            Minus, 
            [Name("×")]
            Times,
            [Name("÷")]
            DividedBy,
            [Name("＝")]
            Equals,
        }
    }
}
