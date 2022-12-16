using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/*https://github.com/git/git/blob/master/Documentation/technical/index-format.txt
	 
		index file is not expected in bare repo.
	 
		 */
	/*
	 The index is a binary file (generally kept in .git/index) containing a sorted list of path names, each with permissions and the SHA1 of a blob object; git ls-files can show you the contents of the index


	The index contains all the information necessary to generate a single (uniquely determined) tree object.
	 */

	/// <summary>
	/// including: index and work.
	/// what is committed is in the index rather than the working tree
	/// </summary>
	/// <see cref="repo.IIndex"/>
	/// alias:
	///		staged
	///			like state,
	///			such as to differ from <see cref="repo.IIndex"/>
	///		index
	public interface IStaged
	{
	}
}
