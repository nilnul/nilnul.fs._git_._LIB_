using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.checkout_.xpn_
{
	/// <summary>
	/// eg:
	///		in gitee web, we can name a folder as "abc."
	///		, it can be cloned to local, but when it's being checked out, an xpn is thrown complaining: path cannot be created. And windows doesnot allow such name, even though linux allows for it;
	///		
	/// </summary>
	/// <remarks>
	/// to resolve this:
	///		1) rename that in gitee web to remove the trailing dot;
	///			,this is called YanJing solution, as Yanjing, the student in webpage24s class, first brought that to our attention.
	///		or
	///		2)  core.protectNTFS
	///		, or core.protectntfs ?
	///		, If set to true, do not allow checkout of paths that would cause problems with the NTFS filesystem, e.g. conflict with 8.3 "short" names. Defaults to true on Windows, and false elsewhere.
	///		, and once configured, the name would be removed trailing dot automatically when being checked out;
	///		, (^1)
	/// </remarks>
	/// ^1: https://git-scm.com/docs/git-config#Documentation/git-config.txt-coreprotectNTFS
	internal class PathUnable2create
	{
	}
}
