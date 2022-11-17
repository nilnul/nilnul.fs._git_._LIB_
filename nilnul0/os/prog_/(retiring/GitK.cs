using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git
{
	[Obsolete(nameof(nilnul.fs.git.module.repo._GitkX))]
	static public class _GitkX
	{
		static public void Gitk(nilnul.fs.Folder workingDir) {
			nilnul.win.ProcessX.RunCmd(workingDir, "gitk.exe");
		}
	}
}
