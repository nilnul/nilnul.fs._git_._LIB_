using nilnul.fs.git.depo.pier.commit_;
using nilnul.fs.git.module.repo.snaps;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.depo._werk_.destinys_
{
	/// <summary>
	/// in any snap, including any branch,tag or HEAD, of the repo.
	/// 
	/// </summary>
	/// for dangling snap, which is to be pruned, we are unsure.
	interface IRepoed
	{
	}

	static public class _RepoedX
	{
		static public IEnumerable<string> _Destinys_0depo(string depo, nilnul.os.prog_.Git git = default)
		{

			/// https://stackoverflow.com/questions/543346/list-all-the-files-that-ever-existed-in-a-git-repository/543426#543426
			///
			/// This does the right thing for checking if a filename was ever present in the repo not just on the current branch.
			/// git log --all--pretty = format: --name - only--diff - filter = A
			///

			const string argument =
				//"log --all --pretty=format: --name-only --diff-filter=A"
			 "log --all --pretty=format: --name-only";

			/// ,where for "A", Current version (without sed filtering only added files) would fail if you have enabled rename detection and have renames in history.
			/// ,--diff-filter=A ignores files that were created by copying an already existing file, so adding it may not always be what you want.
			///


			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
								depo,
								argument
								, git
				)
			);
		}

	}
}
