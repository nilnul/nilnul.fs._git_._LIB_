using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.stage
{
	public class ReIni
	{
		/*
		 If you instead do this (note the lack of “.lock” at the end):
rm .git/index


then your git repo will behave in very weird ways. For instance, git status won’t work, and other things break in odd ways. Here’s the fix:
git read-tree --reset HEAD


You’ll lose unstaged changes, but you’ll have your repo back.

		 */
	}
}
