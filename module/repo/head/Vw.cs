using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.head
{
	/*git symbolic-ref */
	static public class _VwX
	{
		/// <summary>
		/// 
		/// </summary>
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
		public static string Txt(ModuleI top, Git git=null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(top, "symbolic-ref HEAD",git);
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
