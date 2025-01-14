using System;

namespace RealTimeBranchesManager.Data.Models;

public class Product
{
	public Guid Id { get; set; }
	public string Title { get; set; }
	public decimal Price { get; set; }
}