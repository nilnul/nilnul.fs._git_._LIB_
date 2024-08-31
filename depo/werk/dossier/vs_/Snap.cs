using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.work.document.vs_
{
	internal class VsSnap
	{

		/*
		The following works for me:

git diff master:foo foo

In the past, it may have been:

git diff foo master:foo


edited Sep 2, 2016 at 0:37
Cymen

answered Feb 2, 2012 at 13:46
Mark Longair


		
		 
stackoverflow.com/questions/9113280/diff-current-working-copy-of-a-file-with-another-branchs-committed-copy
		
		 
		 
		 git difftool tag/branch filename
		 
		 */


		/*
		 git diff master -- foo


there is also a --cached (aka --staged) option for viewing the diff of what you've staged, rather than everything in your working tree		 */

		/*
		 git diff branch1:./eg.cs   eg.cs
		 */
	}
}
