using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.dir.be_.work
{
	static public class _AntoX
	{
		static public bool _Be(
			nilnul.fs.FolderI folder
			,
			nilnul.win.prog_.Git git=null
		) {
			return !be_._WorkX._Be(folder,git);
		}

		static public bool Be(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs._address.DirI dir
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return !be_._WorkX.Be(module,dir,git);
		}


		static public bool Be(
			nilnul.fs.address_.ShieldI _module
			,
			nilnul.fs._address.DirI dir
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Be(
				new nilnul.fs.git.Module(_module)
				,
				dir
				,
				git
			);
		}

	}
}
