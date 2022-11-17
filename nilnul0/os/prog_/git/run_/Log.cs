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
	static public class _LogX
	{
		public static int _ExitCode(string folder, string args, TextWriter msg, TextWriter err, G git=null)
		{
			return nilnul.win.proc_.nonShell_.redirStd_.redirErr_.errAsyn_.stdAsyn_.started_.end.Cod.Singleton.ofAddress(
				folder,

				(git ?? G.StaticInstance).location, 
				args
				,
				msg
				,
				err
			);
		}

		public static int ExitCode(ModuleI module, string v, TextWriter msg, TextWriter err, G git = null)
		{
			return _ExitCode(module.ToString(),v, msg,err,git);
		}
	}
}