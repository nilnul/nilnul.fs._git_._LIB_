using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.current
{
	/// checking out a non-branch name results in a detached HEAD
	/// <summary>
	///  when it's not a branch
	/// </summary>
	static public class _DetachX
	{
		/*
		 Since git 1.7.5 (April 2011), you can use the git checkout --detach command.
(Since Git 2.23 (Q3 2019), you would use git switch --detach)
		 */
		static public void _Detach_addressAssumeModule(string _addressAssumeModule, nilnul.os.prog_.Git git = null)
		{
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
				_addressAssumeModule
				,
				"switch --detach" //
				,
				git
			);
		}
	}
}
