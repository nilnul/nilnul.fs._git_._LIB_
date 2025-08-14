using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.destinys.log_
{
	
	internal class Deleted
	{


		/*The --full-history flag here is important. Without it, Git performs "history simplification" when you ask it for the log of a file, lest it prunes some side branches if the end result is the same
		 * 
		 * 
		 * 
		 
		 git log --full-history -- file_name
The command above lists all the commits (including merge commits) that touched file_name. The last (top) commit is the one that deleted the file.

git log --all -1 -- [file path]

		 */


		/// git log --all --full-history -- "**/thefile.*"
		///

		/*
git log --all --full-history --diff-filter=D -3 "./deng*"
		
		 */

		/*
		 Get all the commits which have deleted files, as well as the files that were deleted:

git log --diff-filter=D --summary
		 */


		/*
		 git log --diff-filter=D --oneline -- path/to/file
		 */


		/*
		  git log --follow -- [file path]
		 git log --oneline --follow -- full/path/to/MyFile.js

		*/

		/*
		git log --stat
		git log --all --stat --diff-filter=D --oneline
git log --all --stat --diff-filter=D --oneline -- '*foo*'

A pathspec can work well together with -p|--patch, if you want to see contents:

git log --all --stat --diff-filter=D --oneline --patch -- '*foo*'

git log --all --stat --diff-filter=D -p

		 */

		/// git log --reverse --format="%H" --full-history HEAD
		///

		/*
		 
		Another approach you can do is to copy the text from the file that was deleted and search in diffs. When the file is deleted the diff will contain all lines from that file as deleted lines, you can search by that deleted lines. Try to use some unique line, specific to deleted file.

git log -G ".*regexp_that_describes_line_from_deleted_file*"

		eg:
git log -G ".*image\:\ confluentinc\/cp\-zookeeper\:5.1.1.*"
		
		 */
	}
}
