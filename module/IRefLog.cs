namespace nilnul.fs.git.module
{
	///gitprotect.io/blog/how-to-use-git-reflog-reflog-vs-log/#:~:text=Git%20reflog%20vs.-,git%20log,other%20hand%2C%20is%20not%20included.
	///stackoverflow.com/questions/17857723/whats-the-difference-between-git-reflog-and-log
	///
	/// Every time your branch tip is updated for any reason, Git stores that information for you in this temporary history.
	/// <summary>
	/// The reflog is an ordered list of the commits that HEAD has pointed to: it's undo history for your repo. 
	/// The reflog is strictly local and isn’t part of the repository. It’s also not included in pushes, fetches, or clones. Basic git actions like commit, branch, reset, rebase, and merge are included in the reflog.
	/// </summary>
	/// <remarks>
	///Git uses the git reflog tool to keep track of changes made to branch tips. It lets you go back to any commit, even if it isn’t referenced by any branch or tag. Following the rewriting of history, the reflog contains information about the former state of branches and allows for reverting to that state if necessary. A reference specifying parameter, sometimes known as a “ref”, can be applied to several git operations. This argument is used to reference a commit. You may keep track of the update time of git references in the local repository using this reflog technique. 
	/// </remarks>
	/// Reflogs keep track of when git references in the local repository were modified. A separate reflog is kept for the git stash, in addition to branch tip reflogs. Reflogs are kept in folders under the.git directory of the local repository.
	///
	/// vs:log <see cref="repo.IGitLog"/>
	/// The most significant distinction between git reflog and log is that the log is a public record of the repository’s commit history, whereas the reflog is private. After a push, fetch or pull, the git log is duplicated as part of the git repository. The git reflog, on the other hand, is not included.
	///git log will start from current HEAD, that is point to some branch (like master) or directly to commit object (sha code), and will actually scan the object files inside .git/objects directory commit after commit using the parent field that exist inside each commit object. (stackoverflow.com/questions/17857723/whats-the-difference-between-git-reflog-and-log)
	///
	/// While “git reflog” is very beneficial for recovering deleted branches and commits, it does have certain disadvantages. Reference logs, for example, are saved locally, so they can’t be pushed or pulled from a remote repository. To preserve disk space, they usually expire or are wiped after a specific period.
	///
	/// expire: a local recording which is pruned after 90 days by default. not more than 2 weeks ago, you most probably are safe;
	///

	interface IRefLog {

		/*
	stackoverflow.com/questions/17857723/whats-the-difference-between-git-reflog-and-log

With the git reflog, it keeps track of everything you've done locally. Did you commit? Reflog tracks it. Did you do a hard reset? Reflog tracks it. Did you amend a commit? Reflog tracks it. Everything you've done locally, there's an entry for it in the reflog.

This isn't true for the log. If you amend a commit, the log only shows the new commit. If you do a reset and skip back a few commits in your history, those commits you skipped over won't show up in the log. When you push your changes to another developer or to GitHub or something like that, only the content tracked in the log will appear. To another developer, it will look like the resets never happened or the amends never happened.

	/// git reflog is often reference as "your safety net"
Also, since the reflog keeps track of things you amended and commits you reset, it allows you to go back and find those commits because it'll give you the commit ids. Assuming your repository hasn't been purged of old commits, that allows you to resurrect items no longer visible in the log. That's how the reflog sometimes ends up saving someone's skin when they need to get back something they thought they inadvertently lost.

After the clone, the reflog is quite sparse:
$ git reflog
46e70ce (HEAD -> master, origin/master, origin/HEAD) HEAD@{0}: clone

However, the git log command will show the entire history of the cloned GitHub repository's commits, which can span years and include hundreds of entries.

you can view the reflog via the git log command with the --walk-reflogs switch:
$ git log --pretty=oneline --walk-reflogs master		





theserverside.com/video/Git-reflog-vs-log-How-these-commit-history-tools-differ
		 
		 */


	}

}
