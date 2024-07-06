using Calculator.Utilities.Methods;
using System.ComponentModel;

namespace Calculator.UserControls.CalcButtons
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
            Margin = new Padding(1);
            ButtonText = ButtonTextEnum.None;
        }
    }
}
