using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.remote.refers_
{
	/*
	  stackoverflow.com/questions/15261880/does-github-garbage-collect-dangling-commits-referenced-in-pull-requests/15269274#15269274

	  Github creates a branch (actually, two) for every pull request. They're in a non-default namespace so you dont usually get them when you pull (or fetch) from the repo.

To see how this looks in practice, do a git ls-remote <REMOTE>, where <REMOTE> is either the name of a remote (if it's one your repo knows) or the URL (it doesn't need to be git remote added for this to work). (This remote should have some pull requests, or you won't be able to see what I mean.)

This will list all refs on the remote (all branches and tags), and you will see some refs like refs/pull/<number>/head and refs/pull/<number>/merge. Those refer to the latest commit in the PR and the commit at which it was merged in, respectively.

	https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/reviewing-changes-in-pull-requests/checking-out-pull-requests-locally#modifying-an-inactive-pull-request-locally
	:
You can fetch an open pull request and recreate it as your own.
	However, only collaborators with push access can merge pull requests.



	*/
	/// <summary>
	/// 
	/// </summary>
	internal class IPull
	{
	}
}
