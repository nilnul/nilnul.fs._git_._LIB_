using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.divisions_
{
	/// https://git-scm.com/docs/gitglossary#Documentation/gitglossary.txt-glob
	///
	/// <summary>
	///Git treats the pattern as a shell glob
	///;
	/// wildcards in the pattern will not match a / in the pathname
	/// A leading "**" followed by a slash means match in all directories. For example, "**/foo" matches file or directory "foo" anywhere, the same as pattern "foo".
	///A trailing "/**" matches everything inside. For example, "abc/**" matches all files inside directory "abc"
	/// A slash followed by two consecutive asterisks then a slash matches zero or more directories. For example, "a/**/b" matches "a/b", "a/x/b", "a/x/y/b" and so on.
	/// Other consecutive asterisks are considered invalid.
	/// Glob magic is incompatible with literal magic.
	/// </summary>
	internal class IGlob
	{
	}
}
