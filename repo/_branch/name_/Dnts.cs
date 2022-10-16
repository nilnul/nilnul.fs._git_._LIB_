using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._branch.name_
{
	/// <summary>
	/// some branch is remote branch, and the branch name is: svr1/branch1.
	/// dnts are separated by "/"
	/// each dnt can be separated again by, say, "-"
	/// </summary>
	static public class _DntsX
	{
		static public IEnumerable<string> Txts(string name) {
			return name.Split('/');
		}

	

	}
}
