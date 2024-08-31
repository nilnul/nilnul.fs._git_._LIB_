using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.add_.allBut_.minWinTitled.commit_.allowEmpty_
{
	/// <summary>
	/// buts will be put into ".git/exclude"
	/// </summary>
	static public class _MinWinTitledX
	{

		static public int CommitExitCode_AddAndCommit(
			nilnul.fs.git.ModuleI module
			,
			IEnumerable<nilnul.fs._address.DivisionI> buts
			,
			nilnul.fs.git.module.index._commit.Msg msg
			,
			nilnul.win.prog_.Git git=null
		)
		{
			var err=index.add_.allBut_._MinWinTitledX.ExitCode(module,buts, git);
			if (err==0)
			{
				return	nilnul.fs.git.module.index.commit_.allowEmpty_._MinUiTitledX.ExitCode(module, msg, git);
			}
			else
			{
				return 1;
			}
		}

		static public int CommitExitCode_AddAndCommit( string module, IEnumerable<nilnul.fs._address.DivisionI> buts, string _msg, nilnul.win.prog_.Git git=null)
		{
			return CommitExitCode_AddAndCommit(
				 nilnul.fs.git.Module.FroAddress(module)
				, 
				 buts
				,
				 new nilnul.fs.git.module.index._commit.Msg(_msg)
				,git
			);
		}

		static public int CommitExitCode_AddAndCommit(
			string module, IEnumerable<string> buts, string _msg, nilnul.win.prog_.Git git=null
		)
		{
			return CommitExitCode_AddAndCommit(
				 nilnul.fs.git.Module.FroAddress(module)
				, 
				 buts.Select(x=>nilnul.fs._address.DivisionA.Parse(x) )
				,
				 new nilnul.fs.git.module.index._commit.Msg(_msg)
				,git
			);
		}



	}
}
