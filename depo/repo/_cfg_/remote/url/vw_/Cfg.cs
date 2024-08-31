using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.url.vw_
{
	static public class _CfgX
	{

		/*
		If referential integrity has been broken:
git config --get remote.origin.url

If referential integrity is intact:
git remote show origin
only first url
		 */
		static public string Exe(nilnul.fs.folder_.git_.Top folder, nilnul.fs.git.module.repo._cfg_._remote.Name remote, nilnul.win.prog_.Git git = null)
		{
			return // must be trimmed or / r / n is included
				 nilnul.txt.convert_.trim_.White.Singleton.op(nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"config --get remote.{remote}.url",git));
		}




	}
}
