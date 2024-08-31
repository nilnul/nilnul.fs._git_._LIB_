using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.module
{
	public class Submodule
	{

		/*
		  To initialize all your submodules in your local clone, you can use the following command:
git submodule update --init --recursive
The submodule update command will recurse into the registered submodules, update and init (if required) them and any nested submodules within.


		 */

		/*

git submodule foreach --recursive git submodule update --init
foreach will evaluate the command in each checked out submodule. So it will update and init (if required) each submodule and any nested submodules within due to --recursive.

		 */

		/*
		 
		 git submodule update --init --recursive


The submodule update command will recurse into the registered submodules, update and init (if required) them and any nested submodules within.
git submodule foreach --recursive git submodule update --init


foreach will evaluate the command in each checked out submodule. So it will update and init (if required) each submodule and any nested submodules within due to --recursive.

So in the end, both commands will achieve the same thing. Simply the execution differs, the first command won't step into each directory to execute the command

		 */


		/*
		 git submodule update --recursive


You will also probably want to use the --init option to which will make it initialize any uninitialized submodules:
git submodule update --init --recursive


Note: in some older versions of nilnul.win.prog_.Git, if you use the --init option, already-initialized submodules may not be updated. In that case, you should also run the command without --init option.

		 */

		/*
		 git submodule add blah
		 */

		/*
		 git submodule foreach --recursive git fetch
git submodule foreach git merge origin master
git submodule foreach git pull --ff-only origin master

		I also would add --recursive to the last line: "git submodule foreach --recursive git merge origin master" otherwise you can get a dirty submodule when it itself has updated a submodule.
		 */

		/*
		 git submodule update --recursive
		 */


		/*
		 git submodule init 
		 */
		static void Init(string[] args)
		{

		}

		/*
		 



You can use git submodule status or optionally git submodule status --recursive if you want to show nested submodules.

		this kind of commands do not work if the submodules are not initialised yet. No output = no submodule (empty list).

From the GIT SCM docs:


Show the status of the submodules. This will print the SHA-1 of the currently checked out commit for each submodule, along with the submodule path and the output of git describe for the SHA-1. Each SHA-1 will be prefixed with - if the submodule is not initialized, + if the currently checked out submodule commit does not match the SHA-1 found in the index of the containing repository and U if the submodule has merge conflicts.
 
		 */


		/*
git config --list|egrep ^submodule

This does not work if the submodules are not initialised yet – Stefaan Sep 24 '13 at 23:09 

	@IgorGanapolsky just read at Stefaan's comment: This does not work if the submodules are not initialised yet. No output = no submodule (empty list). – Tim Nov 25 '15 at 10:41 
        
This is exaclty what I needed. It shows the subfolders of the submodules and the urls of their remotes. – thinsoldier Dec 10 '15 at 22:08  
		 */


		/*

		 git submodule
		 */

	}
}
