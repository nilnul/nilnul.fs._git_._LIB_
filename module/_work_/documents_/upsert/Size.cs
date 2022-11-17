using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.documents_.upsert
{
	static public class _SizeX
	{
		static public long Bytes(
			string module, nilnul.win.prog_.Git git=null
		) {
			return _UpsertX.Documents(module, git).Select(
				d=>
				new FileInfo(
					System.IO.Path.Combine(module,d)
				).Length
			).Sum();
		}
	}
}
