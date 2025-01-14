using System;
using System.Collections.Generic;

namespace RealTimeBranchesManager.Data.Models;

public class Receipt
{
	public Guid Id { get; set; }
	public Guid CashierId { get; set; }
	public ICollection<Product> Products { get; set; }
}