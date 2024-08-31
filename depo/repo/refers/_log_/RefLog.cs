using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// reflog for module in that it contains detached commits which would be gc-ed later. in lines
	/// log for repo in that it contains the commits. in blocks
	/// </summary>
	public class RefLog
	{
		


		/*
	 git reflog --all 
	 */
	 /// <summary>
	 /// for local branch
	 /// </summary>
	 /// <param name="git"></param>
	 /// <param name="_module"></param>
	 /// <returns></returns>
		static public string RefLogAll(nilnul.win.prog_.Git git, nilnul.fs.Folder _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				_module,
				"reflog --all"
			);
		}

		static public string Exe( nilnul.fs.folder_.git_.Top module, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				module,
				"reflog"
			);
		}

		static public string Exe( nilnul.fs.Folder _module, nilnul.win.prog_.Git git=null)
		{
			return Exe(new fs.folder_.git_.Top(_module),git);
		}

		/// <summary>
		/// for local branch
		/// </summary>
		/// <param name="_module"></param>
		/// <returns></returns>
		static public string RefLogAll(nilnul.fs.Folder _module)
		{
			return RefLogAll(nilnul.win.prog_.Git.StaticInstance, _module);
		}

		/// <summary>
		/// show the pushed
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <param name="remote"></param>
		/// <param name="branch"></param>
		/// <returns></returns>
		static public string ShowRemote(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string remote, string branch)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				_module,
				$"reflog  show {remote}/{branch}"
			);
		}

	}
}
