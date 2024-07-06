namespace Calculator.Commands
{
    public interface ICommand
    {
        void Execute(object? param);
    }
}
