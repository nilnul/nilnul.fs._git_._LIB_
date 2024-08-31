using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.destiny.of_
{
	///git-scm.com/docs/git-checkout
	/// git checkout [-f|--ours|--theirs|-m|--conflict=<style>] [<tree-ish>] --pathspec-from-file=<file> [--pathspec-file-nul]
	/// , where we here only consider when the tree-ish is given:
	///
	/// git checkout  [<tree-ish>] --pathspec-from-file=<file> [--pathspec-file-nul]
	/// 
	/// <summary>
	/// 
	///When the <tree-ish> is given, overwrite both the index and the working tree with the contents at the <tree-ish>
	/// 
	/// </summary>
	/// <remarks>
	///The index may contain unmerged entries because of a previous failed merge. By default, if you try to check out such an entry from the index, the checkout operation will fail and nothing will be checked out. Using -f will ignore these unmerged entries.
	/// </remarks>
	internal class ICheckout
	{
	}
}
