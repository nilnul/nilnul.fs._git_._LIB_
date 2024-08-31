using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.child_.nested
{
	class SubtreeAbsorb
	{
		/*
You can use git subtree to import files from a second repository without their history.

Start from a clean working tree (check with git status). If you've already tried to manually copy files in, delete them. Git will copy them for you.
cd to the top level of your repository.
Run git subtree add --prefix=inner path/to/other/repo some-branch. This creates an inner subdirectory and puts the contents of the other repo's some-branch in it.
Observe that git log shows the history of the imported files.

stackoverflow.com/questions/51516369/how-to-remove-a-git-nested-repo-but-keep-the-files-from-one-of-the-branches
Jul 25, 2018 at 13:22
Maxpm
		
		 */

	}
}
