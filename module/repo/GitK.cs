using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	static public class _GitkX
	{
		static public void _Gitk(nilnul.fs.Folder _workingDir) {

			nilnul.fs.GitK.StaticInstance.runCmd_notOutput(_workingDir, "--all --full-history");
		}
	}
}
