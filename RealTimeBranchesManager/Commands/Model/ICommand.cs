﻿using System.Threading.Tasks;

namespace RealTimeBranchesManager.Commands.Model;

public interface ICommand
{
	public string Id { get; set; }
	public Task Execute();
}