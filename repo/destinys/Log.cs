using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.destinys
{
	/// https://stackoverflow.com/questions/4761562/with-git-how-do-you-search-for-a-file-pattern-with-git-log-instead-of-a-file
	/// <summary>
	/// log --all ./deng*
	///		,where "" is optional when there is no space or punc;
	/// log -- ./deng*
	///		
	/// log --all -3 -- "./deng*"
	///		,where all means all branches
	///		, 3 means 3 most recent snap
	/// </summary>
	internal class Log
	{
		/*
		 
		 git log --diff-filter D --pretty="format:" --name-only

git log -n 1 --pretty=format:%H -- file
		 */

		/*
		 git log --full-history -- file_name
The command above lists all the commits (including merge commits) that touched file_name. The last (top) commit is the one that deleted the file.

		 */
	}
}
