using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.refer.of_
{
	/// <summary>
	/// Find symbolic names for given revs
	/// </summary>
	/// <remarks>
	/// eg:
	///		$ git name-rev 33db5f4d9027a10e477ccf054b2c1ab94f74c85a
	///		33db5f4d9027a10e477ccf054b2c1ab94f74c85a tags/v0.99~940
	///			,where ~940 means 940 revisions before that tag.
	/// </remarks>
	internal class INameRev
	{
	}
}
