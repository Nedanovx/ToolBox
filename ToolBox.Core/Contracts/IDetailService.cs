﻿using ToolBox.Core.Models.Details;
namespace ToolBox.Core.Contracts
{
	public interface IDetailService
	{
		Task<DetailsQueryModel> DetailsBySKUAsync(string sku);
	}
}
