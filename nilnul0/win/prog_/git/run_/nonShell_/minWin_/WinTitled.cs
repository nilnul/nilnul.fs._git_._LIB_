//using nilnul.fs;
using nilnul.fs;
using nilnul.fs.folder_;
using nilnul.fs.folder_.git_;
using nilnul.fs.git;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.prog_.Git;

namespace nilnul.win.prog_.git.run_.nonShell_.minWin_
{
	static public class _WinTitledX
	{
		public static int ExitCode(string folder, string args, G git)
		{
			return nilnul.win.prog.run_.uiTitled_._MinWinX.ExitCode(
				(git ?? G.StaticInstance).location, 
				args,
				folder
			);
		}

		public static int ExitCode(ModuleI module, string v, G git)
		{
			return ExitCode(module.top.en.ToString(),v,git);
		}
	}
}