using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.dir_.work_
{
	static public class _NonsymsX
	{
		public static IEnumerable<nilnul.fs._address.DirI> _Dirs(
		nilnul.fs.address_.ShieldI _top_nonlink
		,
		nilnul.win.prog_.Git git = null
	)
		{
			return nilnul.fs.git.module.dir_._WorksX._Dirs(_top_nonlink,git).Where(
					child =>
					nilnul.fs.folder.dir.be_.symlink._AntoX.Be(_top_nonlink, child)
			);
		}
	}

}
