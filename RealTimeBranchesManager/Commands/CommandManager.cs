using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeBranchesManager.Commands;

public class CommandManager : ICommandManager
{
	private readonly ConcurrentQueue<ICommand> _commandsQueue = new ConcurrentQueue<ICommand>();

	public bool IsRunning = false;
	public int TimeCounter = 0;

	public async Task Run()
	{
		throw new NotImplementedException();
	}

	public async Task<bool> AddCommand(ICommand command)
	{
		var checkAdded = false;

		await Task.Run(() =>
		{
			_commandsQueue.Enqueue(command);
			var commandToCheck = _commandsQueue.FirstOrDefault(c => c.Id == command.Id);
			if (commandToCheck != null && commandToCheck.Id == command.Id) checkAdded = true;
		});

		return checkAdded;
	}

	public async Task RemoveCommand(string commandId)
	{
		throw new NotImplementedException("need to think about implementation");
		var tempList = new List<ICommand>();

		await Task.Run(() =>
		{
			var command = _commandsQueue.FirstOrDefault(c => c.Id == commandId);
			if (command != null && command.Id == commandId)
			{
			}
		});
	}

	public async Task<bool> ClearPendingCommands()
	{
		await Task.Run(() => _commandsQueue.Clear());

		return _commandsQueue.IsEmpty;
	}
}