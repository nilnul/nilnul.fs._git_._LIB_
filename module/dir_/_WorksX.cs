using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.dir_
{
	static public class _WorksX
	{
		public static IEnumerable<nilnul.fs._address.DirI> _Dirs(
		nilnul.fs.address_.ShieldI _top_nonlink
		,
		nilnul.win.prog_.Git git = null
	)
		{
			return nilnul.fs.folder._DirsX.Dirs(_top_nonlink).Where(
					child =>
					nilnul.fs.git.module.dir.be_._WorkX._Be(_top_nonlink, child, git)
			);
		}
	}

}
