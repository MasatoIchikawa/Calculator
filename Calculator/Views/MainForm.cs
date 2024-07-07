using Calculator.ViewModels;

namespace Calculator.Views
{
    public partial class MainForm : Form
    {
        private ViewModel _vm = new ViewModel();
        public MainForm()
        {
            InitializeComponent();

            btnZero.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnOne.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnTwo.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnThree.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnFour.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnFive.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnSix.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnSeven.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnEight.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnNine.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));
            btnDecimalPoint.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, _vm));

            btnPlus.Click += (sender, e) => _vm.PlusCommand.Execute(_vm);
            btnEquals.Click += (sender, e) => _vm.EqualCommand.Execute(_vm);

            btnClearAll.Click += (sender, e) => _vm.ClearAllCommand.Execute(null);
            btnClearEntry.Click += (sender, e) => _vm.ClearEntryCommand.Execute(_vm);
            lblFormula.DataBindings.Add("Text", _vm, "Formal");
            txtResult.DataBindings.Add("Text", _vm, "Result");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {

        }
    }
}
