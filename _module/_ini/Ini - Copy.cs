using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module
{
	[Obsolete()]
	public class _IniX
	{
		static public void Ini(nilnul.win.prog_.Git git, nilnul.fs.Folder folder) {
			git.runCmd_throwErr(folder, "init");
		}


		static public void Ini(nilnul.fs.Folder folder) {
			Ini(nilnul.win.prog_.Git.StaticInstance, folder);
		}

		static public void Ini(string  folder) {
			Ini(new nilnul.fs.Folder(folder));
		}

	}
}
