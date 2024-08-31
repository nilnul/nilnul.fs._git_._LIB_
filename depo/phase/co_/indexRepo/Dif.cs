using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.phase.co_.indexRepo
{
	static public class _DifX
	{
		/*
		To check if there are any changes that are staged but not committed, you can use the return code of:

git diff --cached --exit-code

		git diff [<options>] --cached [<commit>] [--] [<path>…​]

		This form is to view the changes you staged for the next commit relative to the named <commit>. Typically you would want comparison with the latest commit, so if you do not give <commit>, it defaults to HEAD. If HEAD does not exist (e.g. unborn branches) and <commit> is not given, it shows all staged changes. --staged is a synonym of --cached.
*/
		/*--exit-code
		Make the program exit with codes similar to diff(1). That is, it exits with 1 if there were differences and 0 means no differences*/
	}
}
