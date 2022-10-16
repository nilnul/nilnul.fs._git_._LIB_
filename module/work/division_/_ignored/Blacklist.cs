using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.division_._ignored
{
	/*
	 
	 */

	/*
	 a succession of pattern(affirmative or negative)s comes from a collection of files:
	~/. gitignore_global
	 */
	/*

	git ls-files --others --exclude-from=.gitignore
$ git ls-files --others --exclude-from=.git/info/exclude

The --others argument tells the command to show files that are not in the index, and the --exclude-from is a filter to not show files from its parameter. Thus, the first version shows thus the ignored files that are not listed in the .gitignore file.

	--exclude-standard
Add the standard git exclusions: .git/info/exclude, .gitignore in each directory, and the user's global exclusion file.

	 */
	/// <summary>
	/// 
	/// </summary>
	class Blacklist
	{



	}
}
