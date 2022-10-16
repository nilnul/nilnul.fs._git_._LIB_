using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes.exist_
{
	static public class _NamedX
	{
		static public bool Exe(nilnul.fs.folder_.git_.Top module, nilnul.txt_._vered_.Name name, nilnul.win.prog_.Git git = null)
		{

			return remotes._VwX.Seq(module, git).Any( x=>  nilnul.txt_._NameVerX.IsNamedAs(name,x));

		}

		static public bool Exe(nilnul.fs.folder_.git_.Top module, string repoName, nilnul.win.prog_.Git git = null)
		{

			return Exe(module, new nilnul.txt_._vered_.Name(repoName), git);

		}


		static public bool Exe(nilnul.fs.FolderI module, _cfg_._remote.Name repoName, win.prog_.Git git = null)
		{
			return Exe(new fs.folder_.git_.Top(module), repoName, git);
		}

		static public bool Exe(nilnul.fs.FolderI module, string repoName, win.prog_.Git git = null)
		{
			return Exe(module, new _remote.Name(repoName), git);
		}
	}
}
