using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.file
{
	[Obsolete()]
	static public class _CheckoutX
	{

		static public void Act(nilnul.fs.folder_.git_.Top _module, nilnul.win.prog_._git.Arg tag, nilnul.win.prog_._git.Arg file, nilnul.win.prog_.Git git = null)
		{
			(git ?? nilnul.win.prog_.Git.StaticInstance).runCmd_throwErr(_module, $"checkout {tag} { Encoding.Default.GetString(Encoding.UTF8.GetBytes(file.ed))}");
		}

		static public void Act(nilnul.fs.folder_.git_.Top _module, string tag,string file, nilnul.win.prog_.Git git = null)
		{
			Act(_module, new win.prog_._git.Arg(tag), new win.prog_._git.Arg(file), git);
		}


		static public void Act(nilnul.fs.Folder _module, string tag, string file,Git git = null)
		{
			Act(new fs.folder_.GitTop(_module), new win.prog_._git.Arg(tag), new win.prog_._git.Arg(file), git);

		}
	}
}
