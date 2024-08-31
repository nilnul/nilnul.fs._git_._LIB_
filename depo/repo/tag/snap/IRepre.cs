using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.tag.snap
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// note, in cmd, '^' has be be escaped as "^^"
	/// </remarks>
	internal class IRep:repo.IRep
	{

		/*
<rev>^[<n>], e.g. HEAD^, v1.5.1^0
A suffix ^ to a revision parameter means the first parent of that commit object. ^<n> means the <n>th parent (i.e. <rev>^ is equivalent to <rev>^1).
		As a special rule, <rev>^0 means the commit itself and is used when <rev> is the object name of a tag object that refers to a commit object.
		note: you can omit 1, but you cannot omit 0
		 */
		/*
		<rev>^{}, e.g. v0.99.8^{}
A suffix ^ followed by an empty brace pair means the object could be a tag, and dereference the tag recursively until a non-tag object is found.
		*/

		/*
<rev>^{<type>}, e.g. v0.99.8^{commit}
A suffix ^ followed by an object type name enclosed in brace pair means dereference the object at <rev> recursively until an object of type <type> is found or the object cannot be dereferenced anymore (in which case, barf). For example, if <rev> is a commit-ish, <rev>^{commit} describes the corresponding commit object. Similarly, if <rev> is a tree-ish, <rev>^{tree} describes the corresponding tree object. <rev>^0 is a short-hand for <rev>^{commit}.		 
		 */
	}
}
