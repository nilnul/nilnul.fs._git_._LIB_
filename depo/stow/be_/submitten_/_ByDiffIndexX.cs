using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow.be_.submitten_
{
	/*
	git add --all
	git diff-index --exit-code HEAD

		Without add --all, diff-index does not notice untracked files

	 
	 */

	/// <summary>
	/// To check whether the combination of the index and the tracked files in the working tree have changes with respect to HEAD:
	/// git diff-index --quiet HEAD --
	///
	///  it will still report “no differences” if you have a staged change that you have “undone” in the working tree (gone back to the contents that are in HEAD). In this same situation, the two separate commands:<see cref="pier.be_.clean_._ByDiffIndexX"/> and <see cref="werk.be_.all8staged_._ByDiffFilesX"/>, would both return reports of “differences present”.
	/// </summary>
	/// <remarks>
	/// with respect to untracked files, further investigation is needed;
	/// </remarks>
	/// 
	//[Obsolete()]
	static public class _ByDiffIndexX
	{
		static public bool _Be_0depo(string gitTop, nilnul.win.prog_.Git git = null)
		{
			 nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_0address_1argument(   
				gitTop,
				"update-index --refresh "	// in stage, accounted for werk changes 
				, git
			); //

			var result = nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(   
				gitTop,
				"git diff-index --quiet HEAD --"		// exception if head_.branch is unborn
				, git
			);

			if (result.exitCode == 0)  
			{
				return true;


			}

			return false;



		}
		static public bool Be(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git = null)
		{
			return _Be_0depo(gitTop.en.address.en.ToString(), git);



		}

	}
}
