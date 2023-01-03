using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current.create_
{
	public class _BySwitchX
	{
		static public void _Create_addressAssumeModule_assumeBranch(string _addressAssumeModule, string branchName, nilnul.os.prog_.Git git = null)
		{
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
				_addressAssumeModule
				,
				$"switch -c {branchName}" // don't use checkout HEAD
				,
				git
			);
		}

	}
}
