using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._repo.meta
{
	/// <summary>
	/// Pseudorefs are a class of files under $GIT_DIR which behave like refs for the purposes of rev-parse, but which are treated specially by git. Pseudorefs both have names that are all-caps, and always start with a line consisting of a SHA-1 followed by whitespace. So, HEAD is not a pseudoref, because it is sometimes a symbolic ref. They might optionally contain some additional data. MERGE_HEAD and CHERRY_PICK_HEAD are examples. Unlike per-worktree refs, these files cannot be symbolic refs, and never have reflogs. They also cannot be updated through the normal ref update machinery. Instead, they are updated by directly writing to the files. However, they can be read as if they were refs, so git rev-parse MERGE_HEAD will work. 

	/// </summary>
	interface PseudoRefI
	{
	}
}
