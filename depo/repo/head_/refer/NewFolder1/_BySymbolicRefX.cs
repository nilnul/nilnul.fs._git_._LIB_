using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.current.vw_
{
	/*git symbolic-ref */

	[Obsolete(nameof(current_.refer._Vw_bySymbolicRefX))]
	static public class _BySymbolicRefX
	{
		/// <summary>
		/// git symbolic-ref will exit with status 0 if the contents of the	symbolic ref were printed correctly, with status 1 if the requested	   name is not a symbolic ref, or 128 if another error occurs.
		/// </summary>
		/// <remarks>
		///-q, --quiet
		///Do not issue an error message if the <name> is not a symbolic ref           but a detached HEAD; instead exit with non-zero status silently.
		/// </remarks>
		/// <param name="top"></param>
		/// <param name="git"></param>
		/// <returns>
		/// when not detached, show the ref.
		/// when head is missing, show the ref of master
		/// 
		/// </returns>
		/// <exception cref="">
		/// if head is detached, "fatal: ref HEAD is not a symbolic ref"
		/// </exception>

		public static os.proc_.finished._result.CodMsgErr _Result_addressAssumeModule(string top, Git git=null)
		{
			return nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(top, "symbolic-ref HEAD",git);
		}

		public static os.proc_.finished._result.CodMsgErr Result(ModuleI top, Git git=null)
		{
			return _Result_addressAssumeModule(top.ToString(), git);
		}


		public static string Txt(ModuleI top, Git git=null)
		{
			return nilnul.os.proc_.finished._result.data._MsgX.Msg(
				Result(top,git)
			);
		}
		public static string Txt(Module top, Git git=null)
		{
			return Txt((ModuleI)top,git);
		}

		public static string Txt(Top top, Git git=null)
		{
			return Txt(new Module(top),git);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// 
		/// <exception cref="">if detached</exception>
		static public string Txt( nilnul.fs.Folder folder, nilnul.win.prog_.Git git = null)
		{
			return Txt(new Top(folder),git);
		}

	


		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		///
		///<returns>returns refs/heads/your-branch</returns>
		static public string Txt(string module, nilnul.win.prog_.Git git = null)
		{
			///return 
			return Txt(fs.folder_.git_.Top.FroAddress(module), git);

		}

	}
}
