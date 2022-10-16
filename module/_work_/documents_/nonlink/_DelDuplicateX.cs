using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_.nonlink
{
	static public class _DedupX
	{

		static public void _OfAddress(
			string module
			,
			TraceSource log

		)
		{
			if (nilnul.fs.folder.be_._NormalX.Be_ofAddress(module))
			{
				nilnul.fs.git.module_.unlink._work_.documents_.unlink._DelDuplicateX._OfAddress(module, log);
			}

		}



	}
}
