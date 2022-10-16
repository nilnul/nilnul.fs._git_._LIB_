using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.remote_.initial
{
	static public class _VwX
	{
		/*
		git branch -vv
		*/

		static public void Vw(nilnul.fs.Folder folder,  string branch)
		{

			Vw(nilnul.win.prog_.Git.StaticInstance, folder,  branch);
		}
		static public void Vw(nilnul.win.prog_.Git git, nilnul.fs.Folder folder, string branch)
		{

			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				folder,
				$"branch {branch} -vv"
			);
		}

	}
}
