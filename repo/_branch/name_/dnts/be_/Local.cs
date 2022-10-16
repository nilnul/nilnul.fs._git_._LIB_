using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._branch.name_.dnts.be_
{
	static public class _LocalX
	{
		static public int IndexOfSentinel(string local0remoteBranch) {
			return local0remoteBranch.IndexOf('/');
			
		}

		static public bool IsLocal(string local0remoteBranch) {
			var index = local0remoteBranch.IndexOf('/');
			return index < 0;
			
		}

	}
}
