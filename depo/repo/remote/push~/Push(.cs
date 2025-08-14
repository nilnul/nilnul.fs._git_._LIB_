using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.gitTop.module.repo
{
	public class Push
	{
		/*
		 If the QA team wants to push their master branch to qa/master on the remote server, they can run
$ git push origin master:refs/heads/qa/master

If they want nilnul.win.prog_.Git to do that automatically each time they run git push origin, they can add a push value to their config file:
[remote "origin"]
	url = https://github.com/schacon/simplegit-progit
	fetch = +refs/heads/*:refs/remotes/origin/*
	push = refs/heads/master:refs/heads/qa/master

		 */

		/*
		 git push [alias] [branch]
		 
			 */


		/*
		 * 

The entry in the config file would appear like this:


[remote "<name>"]
	url = <url>
	pushurl = <pushurl>
	push = <refspec>
	fetch = <refspec>


The <pushurl> is used for pushes only. It is optional and defaults to <url>.

		 */

		/*
		 git push
Works like git push <remote>, where <remote> is the current branch’s remote (or origin, if no remote is configured for the current branch).

		 */
		static void Default(string[] args)
		{


		}

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
		static public void RemoteBranch(nilnul.win.prog_.Git git, nilnul.fs.Folder folder, string remote, string branch)
		{

			git.runCmd_throwErr(folder,$"push {remote} {branch}");
		}

		static public string RemoteBranch_retRemark(nilnul.win.prog_.Git git, nilnul.fs.Folder folder, string remote, string branch)
		{

			return git.runCmd__returnResult(folder,$"push {remote} {branch}").ToString();
		}


		static public void RemoteBranch( nilnul.fs.Folder folder, string remote, string branch)
		{

			RemoteBranch( nilnul.win.prog_.Git.StaticInstance, folder, remote, branch);
		}

		static public string  RemoteBranch_retRemark( nilnul.fs.Folder folder, string remote, string branch)
		{
			return RemoteBranch_retRemark( nilnul.win.prog_.Git.StaticInstance, folder, remote, branch);
		}




		static public void RemoteBranchThin(nilnul.fs.git.Folder folder, string remote, string branch)
		{

			folder.runCmd_throwErr($"push --thin {remote} {branch}");
		}

		static public void RemoteBranch(nilnul.fs.Git git, string folder, string remote, string branch)
		{

			RemoteBranch(
				git,
				new Folder(
				folder)
				,
				remote,
				branch	
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

		static public void PushAllBranches(nilnul.win.prog_.Git git, string workingDir, string remote)
		{

			git.runCmd_throwErr(workingDir, "push --all " + remote);    //all here means all branches.



		}

		static public void PushAllBranches(nilnul.win.prog_.Git git, nilnul.fs.Folder workingDir, string remote)
		{

			git.runCmd_throwErr(workingDir, "push --all " + remote);    //all here means all branches.

		}

		static public string PushAllBranches_retAll(nilnul.win.prog_.Git git, nilnul.fs.Folder workingDir, string remote)
		{
			var r=
			git.runCmd__returnResult(workingDir, "push --all " + remote);    //all here means all branches.

			return r.ToString();

		}

		static public string PushAllBranches_retAll(Folder folder, string remote) {
			return PushAllBranches_retAll(nilnul.win.prog_.Git.StaticInstance,folder,remote);
		}

		static public string PushAllBranchesByForce_retAll(Folder folder, string remote) {
			return PushAllBranchesByForce_retAll(nilnul.win.prog_.Git.StaticInstance,folder,remote);
		}

		private static string PushAllBranchesByForce_retAll(nilnul.win.prog_.Git git, Folder workingDir, string remote)
		{
			var r=
			git.runCmd__returnResult(workingDir, "push --all -f " + remote);    //all here means all branches.

			return r.ToString();

			//throw new NotImplementedException();
		}

		static public void PushAllBranches(Folder folder, string remote)
		{

			PushAllBranches(nilnul.win.prog_.Git.StaticInstance, folder, remote);



		}

	}
}
