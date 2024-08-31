using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossier.of_
{
	///git-scm.com/docs/git-checkout
	///git checkout [-f|--ours|--theirs|-m|--conflict=<style>] [<tree-ish>] --pathspec-from-file=<file> [--pathspec-file-nul]
	///When the <tree-ish> (most often a commit) is not given (or the default is stage),
	/// that is:
	///git checkout [-f|--ours|--theirs|-m|--conflict=<style>] --pathspec-from-file=<file> [--pathspec-file-nul]
	///		
	/// <summary>
	/// The contents from a specific side of the merge can be checked out of the index by using --ours or --theirs.
	/// 
	/// </summary>
	/// <remarks>
	/// With -m, changes made to the working tree file can be discarded to re-create the original conflicted merge result.
	/// , here m may means "merge", merging 'ours' with 'theirs' from the index
	/// 
	/// </remarks>
	internal class CheckoutFromStage
	{
	}
}
