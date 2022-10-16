using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.head.vw_
{
	static public class _RevParseX
	{
		/// <summary>
		/// detached or not, alwasy show the snap.
		/// </summary>
		/// <param name="top"></param>
		/// <param name="git"></param>
		/// <returns>
		/// if "head" file is missing:
		///		show  a hash of master/branch
		///		
		/// </returns>
		private static string Txt(Top top, Git git)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt( top, "rev-parse HEAD" ,git);

		}



		/*
		 git rev-parse HEAD also yields 17a02998078923f2d62811326d130de991d1a95a
 This is what it means to be a “symbolic ref”. It points to an object through some other reference.
 (Symbolic refs were originally implemented as symbolic links, but later changed to plain files with extra interpretation so that they could be used on platforms that do not have symlinks.)
		 */

		static public string Txt( nilnul.fs.Folder folder, nilnul.win.prog_.Git git=null)
		{
			return Txt(new Top(folder),git);

		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		///git symbolic-ref HEAD 
		///
		///<returns>returns refs/heads/your-branch</returns>
		static public string Txt(string module, nilnul.win.prog_.Git git = null)
		{
			///return 
			return Txt(fs.folder_.git_.Top.FroAddress(module), git);

		}

	}
}
