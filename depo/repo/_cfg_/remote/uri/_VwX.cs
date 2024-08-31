using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.urn
{
	static public class _VwX
	{

		

		/// <summary>
		/// With nilnul.win.prog_.Git 2.7 (release January 5th, 2015), you have a more coherent solution using git remote:
		/// git remote get-url origin
		/// only first one
		/// (nice pendant of git remote set-url origin <newurl>)

		/// </summary>
		/// <param name="folder"></param>
		/// <param name="remote"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string _Txt_assumesModuleAddress1Remote(string folder, string remote, nilnul.win.prog_.Git git=null)
		{

			 return //must be trimmed or /r/n is included
				nilnul.txt.convert_.trim_.White.Singleton.op(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(folder, $"remote get-url {remote}",git)
				);

		}


		static public string Exe(nilnul.fs.git.ModuleI folder, _remote.Name remote, nilnul.win.prog_.Git git=null)
		{

			 return //must be trimmed or /r/n is included
				nilnul.txt.convert_.trim_.White.Singleton.op(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"remote get-url {remote}",git)
				);

		}

		
		static public string Exe(nilnul.fs.folder_.git_.Top folder, _remote.Name remote, nilnul.win.prog_.Git git=null)
		{

			 return //must be trimmed or /r/n is included
				nilnul.txt.convert_.trim_.White.Singleton.op(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"remote get-url {remote}",git)
				);


		}

		public static string Txt_moduleOfBase(Folder folder, _remote.Name remote)
		{
			return Exe(new fs.folder_.git_.Top( folder),(remote));
		}
		public static string Txt_moduleOfBase(Folder folder, string remote)
		{
			return Txt_moduleOfBase(folder,new _remote.Name(remote));
		}
		


	}
}
