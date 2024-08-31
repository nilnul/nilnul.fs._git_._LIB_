using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.werk.be_.all8staged_
{
	/// <summary>
	/// To check whether a working tree has changes that could be staged:
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// 
	//[Obsolete()]
	static public class _ByDiffFilesX
	{
		static public bool _Be_0depo(string gitTop, nilnul.win.prog_.Git git = null)
		{
			var result = nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(    //note: errCode is 1.
				gitTop, "diff-files --quiet", git
			);

			if (result.exitCode == 0)  // 0 if there are still untracked file
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
