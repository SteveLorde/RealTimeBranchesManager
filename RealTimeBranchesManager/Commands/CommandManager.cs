﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealTimeBranchesManager.Commands.Model;

namespace RealTimeBranchesManager.Commands;

public class CommandManager : ICommandManager
{
	private readonly ConcurrentQueue<ICommand> _commandsQueue = new ConcurrentQueue<ICommand>();

	public bool IsRunning;
	public int TimeCounter;

	public async Task Run()
	{
		try
		{
			await Task.Run(async () =>
			{
				IsRunning = true;
				while (IsRunning && !_commandsQueue.IsEmpty)
				{
					TimeCounter += 1;
					_commandsQueue.TryDequeue(out var command);
					if (command != null) await command.Execute();
				}
			});
		}
		finally
		{
			IsRunning = false;
		}
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