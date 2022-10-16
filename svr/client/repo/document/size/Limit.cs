using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client.repo.document.size
{
	/// <summary>
	/// each svr has a limit for an individual file of a repo. if a file exceeds this limit, pushing to the svr would fail.
	/// </summary>
	interface ILimit
	{

	}
}
