using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap
{
	static public class _TagX
	{
		static public void Act(nilnul.fs.folder_.git_.Top _module, nilnul.win.prog_._git.Arg tagName, nilnul.win.prog_._git.Arg snap, nilnul.win.prog_.Git git = null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(_module, $"tag {tagName} {snap}",git);
		}

		static public void Act(nilnul.fs.folder_.git_.Top _module, string tagName,string snap, nilnul.win.prog_.Git git = null)
		{
			Act(_module, new win.prog_._git.Arg(tagName), new win.prog_._git.Arg(snap), git);

		}


		static public void Act(nilnul.fs.Folder _module, string tagName, string snap,Git git = null)
		{
			Act(new fs.folder_.git_.Top(_module), (tagName), (snap), git);

		}
	}
}
