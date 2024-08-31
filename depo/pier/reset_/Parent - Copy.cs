using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.head.move_.to_
{
	[Obsolete("reset staged to previous")]
	static public class _ParentX
	{
		static public void Exe(nilnul.fs.git.Module _location, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.Git.RunCmd_retVoid(
				_location
				,
				"reset " +
					"HEAD" + "^"    //the parent of branch
				+ " -- "    //seperator: before this is tree-ish, after this would be paths
				+ " ."      // all under this directory. //todo: will this be optional?
			);

		}

		static public void _Exe(string _location, nilnul.win.prog_.Git git=null)
		{
			Exe( Module1.OfAddress(_location),git);

		}

	}
}
