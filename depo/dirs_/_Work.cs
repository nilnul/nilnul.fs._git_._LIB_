using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.dirs_
{
	/// <summary>
	/// <seealso cref="nilnul.fs.git.module.dir_.work"/>
	/// </summary>
	static public class _WorkX
	{

		static public IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.git.ModuleI module) {
			return nilnul.fs.folder._DirsX.Dirs(module.top.folder).Where(
				x=>

				dir.be_._WorkX.Be(module,x)
			);
		}

	}
}
