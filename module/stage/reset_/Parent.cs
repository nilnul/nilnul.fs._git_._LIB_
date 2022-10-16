using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.reset_
{
	static public class _ParentX
	{
		static public void Exe(nilnul.fs.git.Module _location, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				_location
				,
				"reset " +
					"HEAD" + "^"    //the parent of branch
				+ " -- "    //seperator: before this is tree-ish, after this would be paths
				+ " ."      // all under this directory. //todo: will this be optional?
				,git
			);

		}

		static public void _Exe(string _location, nilnul.win.prog_.Git git=null)
		{
			Exe( Module.FroAddress(_location),git);

		}

	}
}
