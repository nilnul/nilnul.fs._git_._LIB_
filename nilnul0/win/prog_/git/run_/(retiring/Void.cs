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

namespace nilnul.win.prog_.git.run_
{
	[Obsolete()]
	static public class _VoidX
	{
		public static void Void(string folder, string args, G git)
		{
			 nilnul.win.prog.run_.shell_.wait_._UiTitledX.ExitCode(
				(git ?? G.StaticInstance).location, 
				args,
				folder
			);
		}

		public static void Void(ModuleI module, string v, G git)
		{
			 Void(module.top.en.ToString(),v,git);
		}
	}
}