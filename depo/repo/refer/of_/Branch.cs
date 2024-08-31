using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.reference.construct_
{
	static public class _BranchX
	{
		static public string Exe(string branch) {
			return $"refs/heads/{branch}";
		}
		static public git.repo._reference.Name Exe(repo._branch.Name branch) {
			return new git.repo._reference.Name(Exe(branch.en));
		}
	}
}
