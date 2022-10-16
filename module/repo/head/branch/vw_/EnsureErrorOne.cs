﻿using nilnul.fs.address_;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current.nulable._vw_
{

	/*
	 For my own reference (but it might be useful to others) I made an overview of most (basic command line) techniques mentioned in this thread, each applied to several use cases: HEAD is (pointing at):
•local branch (master)
•remote tracking branch, in sync with local branch (origin/master at same commit as master)
•remote tracking branch, not in sync with a local branch (origin/feature-foo)
•tag (v1.2.3)
•general detached head (none of the above)

Results:
•git branch | sed -n '/\* /s///p' •local branch: master
•remote tracking branch (in sync): (detached from origin/master)
•remote tracking branch (not in sync): (detached from origin/feature-foo)
•tag: (detached from v1.2.3)
•general detached head: (detached from 285f294)

•git status | head -1 •local branch: # On branch master
•remote tracking branch (in sync): # HEAD detached at origin/master
•remote tracking branch (not in sync): # HEAD detached at origin/feature-foo
•tag: # HEAD detached at v1.2.3
•general detached head: # HEAD detached at 285f294

•git describe --all •local branch: heads/master
•remote tracking branch (in sync): heads/master (note: not remotes/origin/master)
•remote tracking branch (not in sync): remotes/origin/feature-foo
•tag: v1.2.3
•general detached head: v1.0.6-5-g2393761

•cat .git/HEAD: •local branch: ref: refs/heads/master
•all other use cases: SHA of the corresponding commit

•git rev-parse --abbrev-ref HEAD
	return "HEAD" when detached
•local branch: master
•all the other use cases: HEAD

•git symbolic-ref --short HEAD 
•local branch: master
•all the other use cases: fatal: ref HEAD is not a symbolic ref

		git symbolic-ref HEAD
refs/heads/develop
$ git symbolic-ref --short HEAD
develop


		git name-rev --name-only HEAD
	 //this will return the branch at the HEAD, even if it's detached.
	


(FYI this was done with git version 1.8.3.1)



	 
	 
	 */
	static public class _VwX
	{

		/*
		 symbolic-ref --short HEAD
			 */
		/// <summary>
		/// </summary>
		/// <param name="git"></param>
		/// <param name="workingDir"></param>
		/// <returns>
		/// when detached,
		///		empty
		///			errorlevel would be 1
		///	when not detached
		///		the branch name
		///
		/// </returns>
		static public string _Nuly_moduleAssumeAddress( string workingDir, nilnul.win.prog_.Git git=null)
		{
			var arg = "symbolic-ref -q --short HEAD";
			var result=win.prog_.git.run._ResultX1.Result_ofAddress(workingDir,arg ,git);
			if (result.exitCode ==1)
			{
				if (string.IsNullOrWhiteSpace(result.msg))
				{
					return null;
				}
				else
				{
					throw new UnexpectedReachException($"when run git {arg} at: {workingDir}, the errorlevel is one, but the msg {result.msg} is unexpectedly nonempty");
				}
			}
			if (result.beErr)
			{


					throw new UnexpectedReachException($"when run git {arg} at: {workingDir}, the errorlevel is nonnil: {result.ToString()} ");

			}
			return (result.msg??"").Trim();


			

		}

	



	}
}
