using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._repo_
{
	/// <summary>
	/// when there is a "MERGE_HEAD" file in ".git" (alongside there might be other docs such as MERGE_NODE, MERGE_MSG), that means there is conflict and we are in the middle of merging.
	/// Git.exe would refuse to go on before you resolve and commit the aforementioned situation.
	/// </summary>
	/// <remarks>
	/// To go on, we need resolve and merge it.
	/// </remarks>
	public class MergeHead
	{
		public const string DNT = "MERGE_HEAD";

		public const string DNT4MSG= "MERGE_MSG";
		public const string DNT4NODE = "MERGE_NODE";
	}
}
