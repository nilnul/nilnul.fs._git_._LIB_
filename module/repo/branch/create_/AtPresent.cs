using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.create_
{
	static public class _AtPresentX
	{
		/*
		

git checkout -b|-B <new_branch> [<start point>] 
Specifying -b causes a new branch to be created as if git-branch[1] were called and then checked out. In this case you can use the --track or --no-track options, which will be passed to git branch. As a convenience, --track without -b implies branch creation; see the description of --track below.


If -B is given, <new_branch> is created if it doesn’t exist; otherwise, it is reset. This is the transactional equivalent of


$ git branch -f <branch> [<start point>]
$ git checkout <branch>


that is to say, the branch is not reset/created unless "git checkout" is successful.


		 */


		static public void _AddAtPresent(nilnul.fs.folder_.git_.Top _module, nilnul.win.prog_._git.Arg _branch, nilnul.win.prog_.Git git = null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(_module, $"checkout -b {_branch}",git);
		}

		static public void _AddAtPresent(nilnul.fs.folder_.git_.Top _module, string _branch, nilnul.win.prog_.Git git = null)
		{
			_AddAtPresent(_module, new win.prog_._git.Arg(_branch), git);

		}


		static public void _AddAtPresent(nilnul.fs.Folder _module, string _branch, nilnul.win.prog_.Git git = null)
		{
			_AddAtPresent(new fs.folder_.git_.Top(_module), new win.prog_._git.Arg(_branch), git);

		}



	}
}
