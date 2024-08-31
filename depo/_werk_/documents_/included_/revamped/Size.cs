using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_.upsert
{
	static  class _SizeX
	{
		static  long Bytes(
			string module, nilnul.win.prog_.Git git=null
		) {
			return _UpsertX.Document0linkEs(module, git).Select(
				d=>
				new FileInfo(
					System.IO.Path.Combine(module,d)
				)	//xpnish, as it might be linked folder.
				.Length
			).Sum();
		}
	}
}
