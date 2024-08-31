using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.tree.blob
{
	/// <summary>
	/// blobish, which can be converted as a treeish;
	/// :[<n>:]<path>, e.g. :0:README, :README
	/// where n is a stage number (0 to 3)
	/// </summary>
	internal class IExpr
	{


		/*
----------------------------------------------------------------------
|         Tree-ish?         |                Examples
----------------------------------------------------------------------
|  :<n>:<path>           | :0:README, :README
----------------------------------------------------------------------
The 0 refers to the merge state, and this concept applies only to blobs, since the index doesn't even contain directories. 
		*/


	}
}
