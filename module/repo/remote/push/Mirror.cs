using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.push
{
	static public class _MirrorX
	{
		static public string Mirror_errAsMsg( nilnul.fs.Folder workingDir, string remote, nilnul.win.prog_.Git git=null)
		{
			return (git??Git.StaticInstance).runCmd__returnResult(workingDir, "push --mirror " + remote).ToString();   


		}
	}

	/*

--all 
Push all branches (i.e. refs under refs/heads/); cannot be used with other <refspec>.


--prune 
Remove remote branches that don’t have a local counterpart. For example a remote branch tmp will be removed if a local branch with the same name doesn’t exist any more. This also respects refspecs, e.g. git push --prune remote refs/heads/*:refs/tmp/* would make sure that remote refs/tmp/foo will be removed if refs/heads/foo doesn’t exist.


--mirror 
Instead of naming each ref to push, specifies that all refs under refs/ (which includes but is not limited to refs/heads/, refs/remotes/, and refs/tags/) be mirrored to the remote repository. Newly created local refs will be pushed to the remote end, locally updated refs will be force updated on the remote end, and deleted refs will be removed from the remote end. This is the default if the configuration option remote.<remote>.mirror is set.
*/


	/*
I'd like to do a git push --mirror that will fail if a non-fast forward update is required.

A git push --mirror should fail if the upstream repo has its config set to receive.denyNonFastForwards true:

git config man page:
receive.denyNonFastForwards



If set to true, git-receive-pack will deny a ref update which is not a fast-forward.
 Use this to prevent such an update via a push, even if that push is forced.
 This configuration variable is set when initializing a shared repository.

That means you wouldn"t have to "reproduce what --mirror" does: you could simply use it, and still have that push fail if any non-fastforward merge is involved.
*/
}
