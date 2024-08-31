using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module._ignore.rules
{
	static public class _DehydrateX
	{

		static public IEnumerable<string> Dehydrate(IEnumerable<string> lines) {
			return lines.Select(
				x=> x.Trim()
			).Where(y=> y!="").Where(
				line=> !line.StartsWith("#")
			);
		}

	

	}
}
