using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.bringOut_
{
	/// <summary>
	/// keep work and ( reset index such that index is aligned with branch and you can then add based on the branch, not on the old Head)
	/// </summary>
	class KeepWork
	{
		/*
		This answer is a bit longer than that of Charles, but it consists solely of basic git commands that I can understand and thus remember, eliminating the need to keep looking it up.
Mark your current location (commit first if needed):

git checkout -b temp


Reset(moves) the marker to the other branch without changing working dir:

git reset<branch where you want to go>


now temp and other branch point to the same commit, and your working dir is untouched.

git checkout <branch where you want to go>


since your HEAD is already pointing to the same commit, working dir is not touched

git branch -d temp


Note that these commands are also readily available from any graphical client.
*/
	}
}
