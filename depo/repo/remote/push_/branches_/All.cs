using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.push_.branches_
{
	/// <summary>
	/// all branches
	/// </summary>
	static public class _AllX
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

		static public string Result( nilnul.fs.git.Module workingDir, _cfg_._remote.Name remote, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run._ResultX.Result(workingDir, "push --all " + remote,git).ToString();    //all here means all branches.
		}

		static public string Result( nilnul.fs.git.Module workingDir,string remote, nilnul.win.prog_.Git git=null)
		{
			return Result(workingDir, new _cfg_._remote.Name(remote), git);
		}

		static public string Result( string workingDir, string remote, nilnul.win.prog_.Git git=null)
		{
			return Result( fs.git.Module.FroAddress(workingDir), new _cfg_._remote.Name(remote),git);
		}

	
		static public string Result( nilnul.fs.folder_.git_.Top workingDir, _cfg_._remote.Name remote, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run._ResultX.Result(workingDir, "push --all " + remote,git).ToString();    //all here means all branches.
		}


		static public string Result( nilnul.fs.Folder workingDir, string remote, nilnul.win.prog_.Git git=null)
		{
			return Result(new fs.folder_.git_.Top(workingDir), new _cfg_._remote.Name(remote),git);
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

	

	}
}
