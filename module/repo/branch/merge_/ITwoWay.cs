using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.merge_
{
	/// <summary>
	/// one of the two way is primary, the other is auxilary; So two way merge is in fact a patch:
	///		apply the auxilary to the primary.
	/// </summary>
	/// vs:
	///		<see cref="IThreeWay"/>
	///	alias:
	///		patch
	///		
	public interface ITwoWay	{	}
}
