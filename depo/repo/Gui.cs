using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	static public class _GuiX
	{
		static public void Gui(nilnul.win.prog_.Git git , nilnul.fs.Folder workingDir) {

			win.prog_.git.run.exitCode.vow_._NilX.Void(workingDir, "gui");
			//nilnul.win.ProcessX.RunCmd(workingDir, "gitk.exe");
		}

		static public void Gui( nilnul.fs.Folder workingDir) {

			Gui(nilnul.win.prog_.Git.StaticInstance, workingDir);
		}

	}
}
