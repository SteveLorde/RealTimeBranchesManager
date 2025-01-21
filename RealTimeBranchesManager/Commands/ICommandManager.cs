using System.Threading.Tasks;
using RealTimeBranchesManager.Commands.Model;

namespace RealTimeBranchesManager.Commands;

public interface ICommandManager
{
	public Task Run();
	public Task<bool> AddCommand(ICommand command);
	public Task RemoveCommand(string commandId);
	public Task<bool> ClearPendingCommands();
}