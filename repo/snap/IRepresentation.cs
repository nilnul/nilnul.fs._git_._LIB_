using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.snap
{

	///git-scm.com/docs/gitrevisions
	/// <summary>
	/// eg:
	///		<rev>^{<type>}, e.g. v0.99.8^{commit}
	///			,A suffix ^ followed by an object type name enclosed in brace pair means dereference the object at <rev> recursively until an object of type <type> is found or the object cannot be dereferenced anymore (in which case, barf). 
	/// </summary>
	/// 
	internal class IRepresentation
	{

		/*
		 git-scm.com/docs/gitrevisions
		  
		@ alone is a shortcut for HEAD

<rev>^{}, e.g. v0.99.8^{}
A suffix ^ followed by an empty brace pair means the object could be a tag, and dereference the tag recursively until a non-tag object is found.


<rev>^{/<text>}, e.g. HEAD^{/fix nasty bug}
A suffix ^ to a revision parameter, followed by a brace pair that contains a text led by a slash, is the same as the :/fix nasty bug syntax below except that it returns the youngest matching commit which is reachable from the <rev> before ^.		 
		 
:/<text>, e.g. :/fix nasty bug
A colon, followed by a slash, followed by a text, names a commit whose commit message matches the specified regular expression. This name returns the youngest matching commit which is reachable from any ref, including HEAD. The regular expression can match any part of the commit message. To match messages starting with a string, one can use e.g. :/^foo. The special sequence :/! is reserved for modifiers to what is matched. :/!-foo performs a negative match, while :/!!foo matches a literal ! character, followed by foo. Any other sequence beginning with :/! is reserved for now. Depending on the given text, the shell’s word splitting rules might require additional quoting.		 */
	}
}
