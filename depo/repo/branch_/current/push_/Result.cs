using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current.push_
{
	static public class _ResultX
	{

		static public string Txt( nilnul.fs.git.ModuleI folder, nilnul.fs.git.module.repo._cfg_._remote.Name remote, nilnul.win.prog_.Git git=null )
		{
			return nilnul.win.prog_.git.run._ResultX1.Result(
					folder
					,
					$"push {remote} HEAD"   //note HEAD is required
					, git
				).ToString();
			;
		}

		static public string Txt( nilnul.fs.git.ModuleI folder, string remote, nilnul.win.prog_.Git git=null )
		{
			return Txt(folder,new _cfg_._remote.Name( remote ),git)	;
		}

		static public string Txt( nilnul.fs.folder_.git_.Top folder, nilnul.fs.git.module.repo._cfg_._remote.Name remote, nilnul.win.prog_.Git git=null )
		{
			return nilnul.win.prog_.git.run._ResultX.Result(
					folder
					,
					$"push {remote} HEAD"   //note HEAD is required
					, git
				).ToString();
			;
		}
	

		public static string Txt(fs.Folder gitTop, string kEY, nilnul.win.prog_.Git git)
		{
			return Txt(new nilnul.fs.folder_.git_.Top( gitTop), new nilnul.fs.git.module.repo._cfg_._remote.Name(kEY), git);
			//throw new NotImplementedException();
		}




	}
}
