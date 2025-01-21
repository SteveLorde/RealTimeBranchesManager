namespace RealTimeBranchesManager.Commands;

public interface ICommand
{
	public string Id { get; set; }
	void Execute();
}