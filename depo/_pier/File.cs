using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._pier
{
	/// <summary>
	/// "index" in the ".git/" dir;
	/// bare repositories don't store the index: it is generated at clone time.
	/// </summary>
	/// <remarks>
	///  If we delete the file, git will assume that the directory listing is empty, and therefore that there are no files in the staging area.
	/// it can also be regenereted by:
	///		git init
	///	the inited repo has no such file either;
	/// </remarks>
	internal class File
	{
	}
}
