using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.add_.all_.minWinTitled.commit_.allowEmpty_
{
	static public class _MinWinTitledX
	{

		static public int CommitExitCode_AddAndCommit(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.index._commit.Msg msg
			,
			nilnul.win.prog_.Git git=null
		)
		{
			var err=index.add_.all_._MinWinTitledX.ExitCode(module, git);
			if (err==0)
			{
				return	nilnul.fs.git.module.index.commit_.allowEmpty_._MinUiTitledX.ExitCode(module, msg, git);
			}
			else
			{
				return 1;
			}
		}

		static public int CommitExitCode_AddAndCommit( string module, string _msg, nilnul.win.prog_.Git git=null)
		{
			return CommitExitCode_AddAndCommit(
				 nilnul.fs.git.Module.FroAddress(module)
				, new nilnul.fs.git.module.index._commit.Msg(_msg)
				,git
			);
		}

	}
}
