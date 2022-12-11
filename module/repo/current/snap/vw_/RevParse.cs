using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.head.snap.vw_
{
	static public class _RevParseShortX
	{
		/// <summary>
		/// Git responds by telling you the unique identifier of HEAD. Let’s suppose it’s bf1908d. 
		/// </summary>
		/// <param name="top"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		private static string Txt(Top top, Git git)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt( top, "rev-parse --short @" ,git);

		}




		static public string Txt( nilnul.fs.Folder folder, nilnul.win.prog_.Git git=null)
		{
			return Txt(new Top(folder),git);

		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		///
		static public string Txt(string module, nilnul.win.prog_.Git git = null)
		{
			///return 
			return Txt(fs.folder_.git_.Top.FroAddress(module), git);

		}

	}
}
