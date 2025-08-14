using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.act_
{
	/// <summary>
	/// similar to <see cref="act_.Reset"/>, but is werk-safe:
	/// : it tries to do a trivial merge in the working directory, so all of the files you haven’t changed will be updated
	/// :  make sure it’s not blowing away files that have changes to them.
	/// </summary>
	/// <remarks>
	///checkout will move HEAD itself to point to another branch, whileas <see cref="Reset"/> changes the branch.
	/// </remarks>
	internal class Checkout
	{
	}
}
