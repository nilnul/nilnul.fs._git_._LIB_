using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._submodule
{
	/*
	 Option #1: Submodules

You can also manage an individual submodule by cd LOCAL_DIR_NAME_I and using normal git commands
1.Setting up:
git submodule add REMOTE_URI_1 LOCAL_DIR_NAME_1
...
...
git submodule add REMOTE_URI_N LOCAL_DIR_NAME_N
git commit -m "Add submodules..."

2.Cloning (the main project)

git clone MAIN_URI REPO && cd REPO && git submodule update --init --recursive

--init will copy the configuration from .gitmodules to .git/config before performing the update (if necessary), and --recursive will do that action recursively in each submodules.

or

git clone --recursive MAIN_URI

--recursive tells git to update and init all submodules on cloning


3.Updating (will preserve unsaved changes)
•Local copy has no un-pushed changes (updates all submodules by default):

git submodule update [LOCAL_DIR_NAME_I ... LOCAL_DIR_NAME_J]
•Local copy has un-pushed changes (updates all submodules by default):

git submodule update --remote --rebase [LOCAL_DIR_NAME_I ... LOCAL_DIR_NAME_J]


4.Publishing/Pushing


This tries a submodule push first and if successful performs a main project push

git push --recurse-submodules=on-demand

Option #2: Subrepositories

You've said you have problems using this method, but I don't understand what they are. Please elaborate if possible.

(the git book also talks about subrepos, but I can't for the life of me find where, right now; let me know if you find it) 
1.Setting up:

NOTE: the master repo will not track changes to subrepo's .git, just to the files themeselves

The slash (/) after the directory name is essential to avoid creating a submodule
git clone REMOTE_URI_1 LOCAL_DIR_NAME_1 && git add LOCAL_DIR_NAME_1/
...
...
git clone REMOTE_URI_N LOCAL_DIR_NAME_N && git add LOCAL_DIR_NAME_N/
git commit -m "Add subrepos..."

If using Composer: (and it is doing the clones for you) you can simply do the adds and commit, but maybe you can configure composer to do this as well.
2.Management

Manage an individual subrep by: `cd LOCAL_DIR_NAME_N' and use normal git commands

Remember that changes to your subrepo files will be tracked by your main repo

The biggest issue here is with cloning (if you want colaborators to be able to work on the subprojects) since your subrepo .git files aren't tracked. Including a file, remote.info in each subrepo that stores the remote should solve this. Then add a script to your main repo that does for each subdirectory cd SUBDIR && git init && cat remote.info | xargs git remote add origin. Depending on what Composer is doing (see questions above) you may want to add a composer update command to this script

Option #3: Subtree Merging

I'm not entirely confident on the subtleties of this method, so I will just link to it

Try this link for a bit of a tutorial

Option #N: Any way you want

Of course you could setup numerous other work flows that in some cases might be simpler. For example you could stick with Composer for dep management and clone your subprojects outside of your main project, creating untracked symlinks in the main project to allow easy access to those files when working on the main project. This could be automated with a script (as could a batch push of all these repos). You could probably even parse composer.json to automatically do this for new (git-based) dependencies.

Note: It seems to me that you don't need to be using Composer at all. If this assumption is incorrect, it is possible that none of the 3 options above will solve your problems. 

	 
	 */


}
