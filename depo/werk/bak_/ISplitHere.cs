using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.werk.bak_
{
	/// <summary>
	/// split large file here, as some svr doesnot allow large file.
	/// We might also need to check the total size, the size of each snap, and make sure new revisions would not be large by, say, committing in many revisions.
	/// </summary>
	internal class ISplitHere
	{
	}
}
