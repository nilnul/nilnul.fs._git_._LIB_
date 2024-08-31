using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.refer_.branch.lex_
{
	///stackoverflow.com/questions/28192422/git-warning-refname-xxx-is-ambiguous/
	///answered Feb 6, 2018 at 21:17
	///Ben Butzer
	/// 
	/// <summary>
	/// eg:
	///		git merge BranchyBranch_r2.1
	///		warning: refname 'BranchyBranch_r2.1' is ambiguous.
	/// ,then you need for disambiguity:
	///		git merge refs/heads/BranchyBranch_r2.1
	/// </summary>
	internal class Abundant
	{
	}
}
