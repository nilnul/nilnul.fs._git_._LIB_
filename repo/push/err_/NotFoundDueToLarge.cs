using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.push.err_
{
	public class NotFoundDueToLarge
	{
		/* I have attempted your solution and this does not fix the problem. I even went so far to have nilnul.win.prog_.Git-LFS manage all the files in the repo but still got the error that I receive with large files:

atalak@JUSL MINGW64 ~/Desktop/GitRepo/HMI (master)
$ git push -u origin --all
Git LFS: (0 of 0 files, 10 skipped) 0 B / 0 B, 331.74 MB skipped               Counting objects: 4601, done.
Delta compression using up to 8 threads.
Compressing objects: 100% (2877/2877), done.
Writing objects: 100% (4601/4601), 351.70 MiB | 348.66 MiB/s, done.
Total 4601 (delta 1652), reused 4540 (delta 1631)
error: RPC failed; HTTP 404 curl 22 The requested URL returned error: 404 Not Found
fatal: The remote end hung up unexpectedly
fatal: The remote end hung up unexpectedly
Everything up-to-date
Monday, August 08, 2016 7:23 PM
Avatar of Tacitus86
Tacitus865 Points
 Question
Sign in to vote
0
Sign in to vote
Any further suggestions would be helpful... 
Wednesday, August 10, 2016 12:19 PM
Avatar of Tacitus86
Tacitus865 Points
 Question
Sign in to vote
1
Sign in to vote
Anyone looking back at this post... I was able to solve the issue by writing:

git config --global --unset http.postBuffer

A good reference post for this is: http://stackoverflow.com/questions/15240815/git-fatal-the-remote-end-hung-up-unexpectedly

Proposed as answer by Sunil Hurkadli Thursday, August 11, 2016 9:40 AM
Marked as answer by Sheethal J S*/

		/*Cause : The default file post size for nilnul.win.prog_.Git has been exceeded.

Solution :

Navigate to repo.

Run the following command to increase the buffer to 500MB after navigating to the repository:

git config http.postBuffer 524288000*/
	}
}
