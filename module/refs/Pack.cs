using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.refs
{
	class Pack
	{
		/*
		 



The other thing gc will do is pack up your references into a single file. Suppose your repository contains the following branches and tags:


$ find .git/refs -type f
.git/refs/heads/experiment
.git/refs/heads/master
.git/refs/tags/v1.0
.git/refs/tags/v1.1


If you run git gc, you’ll no longer have these files in the refs directory. nilnul.win.prog_.Git will move them for the sake of efficiency into a file named .git/packed-refs that looks like this:


$ cat .git/packed-refs
# pack-refs with: peeled fully-peeled
cac0cab538b970a37ea1e769cbbde608743bc96d refs/heads/experiment
ab1afef80fac8e34258ff41fc1b867c702daa24b refs/heads/master
cac0cab538b970a37ea1e769cbbde608743bc96d refs/tags/v1.0
9585191f37f7b0fb9444f35a9bf50de191beadc2 refs/tags/v1.1
^1a410efbd13591db07496601ebc7a059dd55cfe9


If you update a reference, nilnul.win.prog_.Git doesn’t edit this file but instead writes a new file to refs/heads. To get the appropriate SHA-1 for a given reference, nilnul.win.prog_.Git checks for that reference in the refs directory and then checks the packed-refs file as a fallback. However, if you can’t find a reference in the refs directory, it’s probably in your packed-refs file.


Notice the last line of the file, which begins with a ^. This means the tag directly above is an annotated tag and that line is the commit that the annotated tag points to.

		 */
	}
}
