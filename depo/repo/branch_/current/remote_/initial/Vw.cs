using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current.remote_.initial
{
	static public class _VwX
	{
		/*
		git branch -vv
		*/

		static public string Vw(nilnul.fs.Folder folder)
		{

			return VwBranchOnRemote(folder, nilnul.win.prog_.Git.StaticInstance);
		}
		/// <summary>
		/// this shows the remote branch
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string  VwBranchOnRemote( nilnul.fs.Folder folder, nilnul.win.prog_.Git git=null)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				folder,
				//$"branch {nilnul.fs.git.module.repo.branch_.current._VwX.Vw(folder,git)} -vv" //error in attempting to create branch
				$"branch -vv"
			);
		}

		static public string  VwRemoteBranch( nilnul.fs.Folder folder, nilnul.win.prog_.Git git=null)
		{

			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				folder,
				"git rev-parse --abbrev-ref --symbolic-full-name @{u}" //origin/mainline

			);
		}


	}
}
