using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.rel.graph_
{
	/// <summary>
	/// 
	/// </summary>
	internal class IAtCli
	{
		static public void AtCli(string depo, nilnul.os.prog_.Git git = null) {
			new nilnul.win.prog.run_.shell_.NewWin1(git.location).createProc(
				$"""log --all --graph --oneline{
					null
					///--decorate: This will show the branch and tag names for each commit.
					///--color: This will color-code the output.
				}"""
					
			);
		}
	}
}
