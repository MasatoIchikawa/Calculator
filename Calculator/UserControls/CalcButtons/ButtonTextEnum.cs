using Calculator.Utilities.Attributes;

namespace Calculator.UserControls.CalcButtons
{
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
        [Name(".")]
        DecimalPoint,
        [Name("+")]
        Plus,
        [Name("-")]
        Minus,
        [Name("×")]
        Times,
        [Name("÷")]
        DividedBy,
        [Name("＝")]
        Equals,
        [Name("CE")]
        ClearEntry,
        [Name("C")]
        ClearAll
    }
}
