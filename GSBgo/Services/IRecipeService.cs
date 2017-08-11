using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using GSBgo.Business;

namespace GSBgo.Services
{
	public interface IRecipeService
	{
		Task<IList<RecipeGroup>> GetRecipeGroups();
	}
}
