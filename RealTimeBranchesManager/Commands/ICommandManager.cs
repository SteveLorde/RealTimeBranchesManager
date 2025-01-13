using System.Threading.Tasks;

namespace RealTimeBranchesManager.Commands;

public interface ICommandManager
{
	public Task Run();
	public Task AddCommand(ICommand command);
	public Task RemoveCommand(ICommand command);
	public Task ClearPendingCommands();
}