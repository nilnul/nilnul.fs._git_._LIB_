using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg
{
	/*
	You can tell nilnul.win.prog_.Git to ignore certain files by creating a file called .gitignore in the top level of your working directory, with contents such as:

# Lines starting with '#' are considered comments.
# Ignore any file named foo.txt.
foo.txt
# Ignore (generated) html files,
*.html
# except foo.html which is maintained by hand.
!foo.html
# Ignore objects and archives.
*.[oa]See gitignore(5) for a detailed explanation of the syntax. You can also place .gitignore files in other directories in your working tree, and they will apply to those directories and their subdirectories. The .gitignore files can be added to your repository like any other files (just run git add .gitignore and git commit, as usual), which is convenient when the exclude patterns (such as patterns matching build output files) would also make sense for other users who clone your repository.

If you wish the exclude patterns to affect only certain repositories (instead of every repository for a given project), you may instead put them in a file in your repository named .git/info/exclude, or in any file specified by the core.excludesFile configuration variable. Some nilnul.win.prog_.Git commands can also take exclude patterns directly on the command line. See gitignore(5) for the details.

	 */
	[Obsolete(nameof(fs.git.module.work.div.doc_.Ignore),true)]
	public class Ignore
	{
		public const string IgnoreFileName = ".gitignore";
	}
}
