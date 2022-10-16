using nilnul.dev.git;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch
{
	public class Push
	{ 
		/*
		 git push origin
Without additional configuration, pushes the current branch to the configured upstream (remote.origin.merge configuration variable) if it has the same name as the current branch, and errors out without pushing otherwise.


The default behavior of this command when no <refspec> is given can be configured by setting the push option of the remote, or the push.default configuration variable.


For example, to default to pushing only the current branch to origin use git config remote.origin.push HEAD. Any valid <refspec> (like the ones in the examples below) can be configured as the default for git push origin.

			 */
		static void PushByRemotes(string[] args)
		{

		}

		/*
		 git push origin master
Find a ref that matches master in the source repository (most likely, it would find refs/heads/master), and update the same ref (e.g. refs/heads/master) in origin repository with it. If master did not exist remotely, it would be created.

			 */
		static public void RemoteBranch(nilnul.fs.FolderI folder, string remote, string branch, Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(folder, $"push {remote} {branch}",git);
		}
	
		static public void RemoteBranch( nilnul.fs.Folder folder, string remote, string branch,nilnul.win.prog_.Git git=null)
		{

			 RemoteBranch((FolderI)folder, remote, branch, git);
		}

		

		

		static public void RemoteBranch_ofAddress(string folder, string remote, string branch, Git git=null )
		{

			RemoteBranch(
				 Folder.FroAddress(folder)
				,
				remote,
				branch	
				,git
			);
		}


		/*
		 git push origin +dev:master
Update the origin repository’s master branch with the dev branch, allowing non-fast-forward updates. This can leave unreferenced commits dangling in the origin repository. Consider the following situation, where a fast-forward is not possible:


	    o---o---o---A---B  origin/master
		     \
		      X---Y---Z  dev


The above command would change the origin repository to


		      A---B  (unnamed branch)
		     /
	    o---o---o---X---Y---Z  master


Commits A and B would no longer belong to a branch with a symbolic name, and so would be unreachable. As such, these commits would be removed by a git gc command on the origin repository.

			 */
		static void NonFastforward(string[] args)
		{

		}

	

	}
}
