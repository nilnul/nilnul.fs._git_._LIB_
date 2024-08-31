using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._reference._name.txt.be_
{
	/// <summary>
	/// https://mirrors.edge.kernel.org/pub/software/scm/git/docs/git-check-ref-format.html
	/// </summary>
	static public class _ByGitX
	{
		/// <summary>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		static public bool Be(string obj, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run._ExitCodeX._ExitCode(
				$"check-ref-format {obj}"
				,
				git
			)==0;
		}
	}
}
