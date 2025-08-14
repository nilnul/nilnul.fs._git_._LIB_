using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.remote.refers
{
	/// stackoverflow.com/questions/15261880/does-github-garbage-collect-dangling-commits-referenced-in-pull-requests/15269274#15269274
	///
	///  Github creates a branch (actually, two) for every pull request. They're in a non-default namespace so you dont usually get them when you pull (or fetch) from the repo.
	/// To see how this looks in practice, do a git ls-remote <REMOTE>, where <REMOTE> is either the name of a remote (if it's one your repo knows) or the URL (it doesn't need to be git remote added for this to work). This remote should have some pull requests, or you won't be able to see what I mean.
	/// This will list all refs on the remote (all branches and tags), and you will see some refs like refs/pull/<number>/head and refs/pull/<number>/merge. Those refer to the latest commit in the PR and the commit at which it was merged in, respectively.
	/// they will not be gc's because they're not wholly unreferenced even if you delete your branch.
	/// commits in a pull request are available in a repository even before the pull request is merged. You can fetch an open pull request and recreate it as your own.
	/// ^docs.github.com/en/pull-requests/collaborating-with-pull-requests/reviewing-changes-in-pull-requests/checking-out-pull-requests-locally#modifying-an-inactive-pull-request-locally
	///
	/// Anyone can work with a previously opened pull request to continue working on it, test it out, or even open a new pull request with additional changes. However, only collaborators with push access can merge pull requests.
	/// Fetch the reference to the pull request based on its ID number, creating a new branch in the process.
	/// git fetch origin pull/ID/head:BRANCH_NAME
	///
	/// The remote refs/pull/ namespace is read-only. (deny updating a hidden ref)
	/// 
	/// <summary>
	/// git ls-remote
	/// </summary>
	/// git-scm.com/docs/git-ls-remote
	static public class _VwX
	{
		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		///
		/// <returns>
		/// in format of:
		/// <oid> TAB <ref> LF
		/// eg:
		/// 73717638a98239c930eb3605ae06778cf7049ee4        HEAD
		/// 73717638a98239c930eb3605ae06778cf7049ee4 refs/heads/master
		/// 1afdac3e88829a968f5aeacd6dab31977d53873a refs/heads/revert-merge-209-master
		/// f4b6a34a1c7c4e4c774905e68cd6e9ebfc16a6cd        refs/pull/1/MERGE
		/// a379bc402e77783dc8064d26e597aa0e02ba5916        refs/pull/1/head
		/// 921837897556ec2e8871758e10c839af528e536c refs/pull/10/MERGE
		/// 2263175e2033446b777b5fb58fa307b63f6ebcff refs/pull/10/head
		/// add12e79b2089400edbc4b69ac5f1c43173e3a4d        refs/pull/100/MERGE
		/// 9f166fb9bdc68ccd1840c3c9c22d7da11b1f3f05 refs/pull/100/head
		/// </returns>
		static public string _Msg_0depo_1remote(
			string depo, string remote, nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo
				,
				$"ls-remote {remote}"
				,
				git
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="remote"></param>
		/// <param name="options">
		///refs
		///		:exclude HEAD
		///		:exclude peeled tags
		///	tags
		///	
		///	branches	
		/// </param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string _Msg_0depo_1remote_2options(
			string depo, string remote, string[] options, nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo
				,
				$"ls-remote {string.Concat(" ",options.Select( o=>$"--{o}"))} {remote}"
				,
				git
			);
		}


	}
}
