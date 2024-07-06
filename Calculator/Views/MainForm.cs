using Calculator.ViewModels;

namespace Calculator.Views
{
    public partial class MainForm : Form
    {
        private ViewModel _vm = new ViewModel();
        public MainForm()
        {
            InitializeComponent();

            btnZero.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnOne.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnTwo.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnThree.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnFour.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnFive.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnSix.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnSeven.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnEight.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnNine.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnDecimalPoint.Click += (sender, e) => _vm.InputCommand.Execute(Tuple.Create(sender!, txtResult));
            btnClearEntry.Click += (sender, e) => _vm.ClearEntryCommand.Execute(null);
            txtResult.DataBindings.Add("Text", _vm, "Result");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {

        }
    }
}
