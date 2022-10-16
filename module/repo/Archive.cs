using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	class Archive
	{
		/*
		 
•you can use git archive (see Jared Forsyth's answer and Robert Knight's answer), since git1.7.9.5 (March 2012):
git archive --remote=git://git.foo.com/project.git HEAD:path/to/directory filename | tar -x




That will save a copy of 'filename' from the HEAD of the remote repository in the current directory.

The :path/to/directory part is optional. If excluded, the fetched file will be saved to <current working dir>/path/to/directory/filename.

		 */
	}
}
