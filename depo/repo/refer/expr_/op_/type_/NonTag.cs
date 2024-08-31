using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.refer.expr_.op_.type_
{
	/// <summary>
	/// <rev>^{}, e.g. v0.99.8^{}
	/// A suffix ^ followed by an empty brace pair means the object could be a tag, and dereference the tag recursively until a non-tag object is found.
	/// </summary>
	internal class NonTag
	{
	}
}
