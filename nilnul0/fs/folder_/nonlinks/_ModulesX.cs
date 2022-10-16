using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.nonlinks
{
	static public class _ModulesX
	{
		

		static public IEnumerable<nilnul.fs.git.ModuleI> Seq_disregardRepo(
			nilnul.fs.folder_.nonlink.Set nonlinks
		)
		{
			return nonlinks.SelectMany( x=> folder_.nonlink._ModulesX.Seq_disregardRepo(x) );
		}

	}
}
