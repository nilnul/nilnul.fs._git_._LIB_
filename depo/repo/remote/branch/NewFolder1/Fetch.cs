using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote
{
	static public class _FetchX
	{
		/*
		 Instead of fetching all remotes, both fetch and remote update allow you to specify multiple remotes and groups of remotes to fetch:
git fetch [<options>] <group>
git fetch --multiple [<options>] [(<repository> | <group>)…]


git fetch [<options>] <group> allows you to fetch multiple remotes that are part of a group (to borrow another example from Mislav):
$ git config remotes.mygroup 'remote1 remote2 ...'
$ git fetch mygroup


git fetch --multiple allows you to specify several repositories and repository groups to fetch at once (from the docs):


Allow several <repository> and <group> arguments to be specified. No <refspec>s may be specified.
*/
		static void FetchMultiple(string[] args)
		{

		}

		/*
		 To pull the master branch on the remote down to origin/mymaster locally, you can run
$ git fetch origin master:refs/remotes/origin/mymaster

		 */

		static void Branch(string[] args)
		{

		}

		/*
		 You can also specify multiple refspecs. On the command line, you can pull down several branches like so:
$ git fetch origin master:refs/remotes/origin/mymaster \
	 topic:refs/remotes/origin/topic
From git@github.com:schacon/simplegit
 ! [rejected]        master     -> origin/mymaster  (non fast forward)
 * [new branch]      topic      -> origin/topic

In this case, the master branch pull was rejected because it wasn’t a fast-forward reference. You can override that by specifying the + in front of the refspec.

		 */

		static void Main(string[] args)
		{

		}

		/*
		 You might already know that you can "fork" repositories on GitHub.

When you clone a repository you own, you provide it with a remote URL that tells nilnul.win.prog_.Git where to fetch and push updates. If you want to collaborate with the original repository, you'd add a new remote URL, typically called upstream, to your local nilnul.win.prog_.Git clone:
git remote add upstream  <THEIR_REMOTE_URL> 


Now, you can fetch updates and branches from their fork:
git fetch upstream
# Grab the upstream remote's branches
remote: Counting objects: 75, done.
remote: Compressing objects: 100% (53/53), done.
remote: Total 62 (delta 27), reused 44 (delta 9)
Unpacking objects: 100% (62/62), done.
From https://github.com/octocat/repo
 * [new branch]      master     -> upstream/master


When you're done making local changes, you can push your local branch to GitHub and initiate a pull request.

For more information on working with forks, see "Syncing a fork".

		 */


		static public void _Fetch(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string remote) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(_module, $"fetch {remote}");

		}

		static public void _Fetch( nilnul.fs.Folder _module, string remote, nilnul.win.prog_.Git git=null) {
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(_module, $"fetch {remote}",git);

		}

	}
}
