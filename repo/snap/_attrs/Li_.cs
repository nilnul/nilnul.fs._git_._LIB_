using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.snap._attrs
{
	internal enum Li_
	{

		/// <summary>
		/// eg:
		///		$ git cat-file -p fdf4fc3
		///		tree d8329fc1cc938780ffdd9f94e0d364e0ea74f579
		///		author Scott Chacon <schacon@gmail.com> 1243040974 -0700
		///		committer Scott Chacon <schacon@gmail.com> 1243040974 -0700
		/// </summary>
		/// <remarks>
		/// The author is the person who originally wrote the work, whereas the committer is the person who last applied the work. 
		/// </remarks>
		/// <!---->
		Author
			,

		/// <summary>
		/// eg:
		///		$ git cat-file -p fdf4fc3
		///		tree d8329fc1cc938780ffdd9f94e0d364e0ea74f579
		///		author Scott Chacon <schacon@gmail.com> 1243040974 -0700
		///		committer Scott Chacon <schacon@gmail.com> 1243040974 -0700
		/// </summary>
		Commiter
	}
}
