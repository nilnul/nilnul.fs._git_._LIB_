using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.document.create_.froRepo_
{
	/*git show experiment:path/to/app.js > app.js
works too, except that, as detailed in the SO question "How to retrieve a single file from specific revision in nilnul.win.prog_.Git?", you need to use the full path from the root directory of the repo.
Hence the path/to/app.js used by Jakub in his example.

As Frosty mentions in the comment:

you will only get the most recent state of app.js

But, for git checkout or git show, you can actually reference any revision you want, as illustrated in the SO question "git checkout revision of a file in git gui":

$ git show $REVISION:$FILENAME
$ git checkout $REVISION -- $FILENAME
would be the same is $FILENAME is a full path of a versioned file.

$REVISION can be as shown in git rev-parse:

experiment@{yesterday}:app.js # app.js as it was yesterday 
experiment^:app.js            # app.js on the first commit parent
experiment@{2}:app.js         # app.js two commits ago*/

	class ByShow
	{
		/*You can use "git show" for that:

prompt> git show HEAD^:main.cpp > old_main.cpp
(Note that there is colon ':' character between HEAD^ and main.cpp`.) The "<revision>:<path>" syntax is described in git rev-parse manpage, next to last point in the "Specifying revisions" section:

<rev>:<path>, e.g. HEAD:README, :README, master:./README
A suffix : followed by a path names the blob or tree at the given path in the tree-ish object named by the part before the colon. :path (with an empty part before the colon) is a special case of the syntax described next: content recorded in the index at the given path.

A path starting with ./ or ../ is relative to the current working directory. The given path will be converted to be relative to the working tree’s root directory. This is most useful to address a blob or tree from a commit or tree that has the same tree structure as the working tree.

Note that "<path>" here is FULL path relative to the top directory of your project, i.e. the directory with .git/ directory. (Or to be more exact to "<revision>" (which in general can be any <tree-ish>, i.e. something that represents tree))

If you want to use path relative to the current directory, you need to use "./<path>" syntax (or "../<path>" to go up from current directory).

Edit 2015-01-15: added information about relative path syntax

You can get in most cases the same output using low-level (plumbing) git cat-file command:

prompt> git cat-file blob HEAD^:main.cpp > old_main.cpp*/

		/*UPDATE3: Karmi's answer, for a specific revision:

prompt> git show 4c274dd91dc:higgs/Higgs.xcodeproj/project.pbxproj > old_project.pbxproj
prompt> */
	}
}
