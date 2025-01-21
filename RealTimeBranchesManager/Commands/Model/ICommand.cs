namespace RealTimeBranchesManager.Commands.Model;

public interface ICommand
{
	public string Id { get; set; }
	void Execute();
}