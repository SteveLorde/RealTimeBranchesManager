using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RealTimeBranchesManager.Commands.Model;

namespace RealTimeBranchesManager.Services;

public static class ICommandJSONUtility
{
	public static string Serialize(ICommand command)
	{
		return JsonSerializer.Serialize(command);
	}

	public static async Task<ICommand> DeSerialize(string serializedCommand)
	{
		throw new NotImplementedException("work on polymorphic converter");

		var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(serializedCommand));

		var command = await JsonSerializer.DeserializeAsync<ICommand>(memoryStream);

		if (command == null) throw new NullReferenceException("deserialized command is null");

		return command;
	}
}