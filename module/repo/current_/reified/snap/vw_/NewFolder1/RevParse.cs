using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.head.vw_
{

	[Obsolete(nameof(current))]
	static public class _RevParseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="top"></param>
		/// <param name="git"></param>
		/// <returns>
		/// the commit, even in undetached mode; the ref is not shown;
		/// </returns>
		/// <exception cref="">
		/// if the branch is not reified:::
		/// fatal: ambiguous argument 'HEAD': unknown revision or path not in the working tree.
		/// Use '--' to separate paths from revisions, like this:
		/// 'git <command> [<revision>...] -- [<file>...]'
		/// HEAD
		/// </exception>
		public static string _TxtByUsingHead_assumeAddress(string top, Git git)
		{
			return nilnul.os.prog_.git.run_.exit_.onDue.result._MsgX.OfAddress( top, "rev-parse HEAD" ,git)?.Trim();

		}

		/// <exception cref="">
		/// if the branch is not reified:::
		/// fatal: ambiguous argument 'HEAD': unknown revision or path not in the working tree.
		/// Use '--' to separate paths from revisions, like this:
		/// 'git <command> [<revision>...] -- [<file>...]'
		/// HEAD
		/// </exception>
		public static string _Txt_assumeAddress(string top, Git git)
		{
			return nilnul.os.prog_.git.run_.exit_.onDue.result._MsgX.OfAddress( top, "rev-parse @" ,git)?.Trim();

		}

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
		public static string Txt(Top top, Git git)
		{
			return _Txt_assumeAddress( top.en.ToString(), git);

		}


		public static string Txt(ModuleI top, Git git)
		{
			return _Txt_assumeAddress( top.ToString(), git);
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
