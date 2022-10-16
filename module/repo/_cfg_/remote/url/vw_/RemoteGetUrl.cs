using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.url.vw_
{
	static public class _RemoteGetUrlX
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
		static public string Exe(nilnul.fs.git.ModuleI folder, _remote.Name remote, nilnul.win.prog_.Git git=null)
		{

			 return //must be trimmed or /r/n is included
				nilnul.txt.convert_.trim_.White.Singleton.op(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"remote get-url {remote}",git)
				);

		}


		static public nilnul.web.Url3 Url(nilnul.fs.git.ModuleI folder, _remote.Name remote, nilnul.win.prog_.Git git=null)
		{

			return nilnul.web.url._ParseX3.Parse(
				Exe(folder,remote,git)
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
		public static web.url_.SchemedNodewise Url_moduleOfBase(Folder folder, string remote)
		{
			return nilnul.web.url_.SchemedNodewise.Parse( Txt_moduleOfBase(folder,(remote)) );
		}


	}
}
