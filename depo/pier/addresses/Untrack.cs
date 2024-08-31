using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage.addresses
{
	class Untrack
	{
		/*
		 If you already have any bin folders in your git index which you no longer wish to track then you need to remove them explicitly. nilnul.win.prog_.Git won't stop tracking paths that are already being tracked just because the now match a new .gitignore pattern. Execute a folder remove (rm) from index only (--cached) recursivelly (-r). Command line example for root bin folder:

git rm -r --cached bin
		 */
	}
}
