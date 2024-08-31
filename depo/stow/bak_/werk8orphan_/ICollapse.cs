using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow.bak_.werk8orphan_
{
	internal class ICollapse
	{
		/// todo:
		/// 
		///  for pier:
		///		for hence, collapse the tag if the two tag points to the same tree, and the parent of the commit of either is same snap;
		///		for orphan, collapse if there already exists an orphan tag points to the same tree.
		///		
		///	for werk:
		///		there exists a sequence of batches, each of which, correspondingly, has the same tree
		///
		/// to collapse, we can keep the tag, but let the tag point to an old snap;
	}
}
