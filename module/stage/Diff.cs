using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage
{
	/// <summary>
	/// git diff --cached
	/// 
	/// Use git diff --cached to review the changes that you have staged for commit. This is the exact diff that git commit will produce as long as you don't use the -a flag.
	/// </summary>
	public class Diff
	{



	}

	/*
	 So there are three types of diff you can ask for:

1.git diff --cached
	This is the difference between what is in the index and the last commit. It shows you that changes that will be in the next commit.


2.git diff
	This shows the difference in between the index and the working tree. These are the changes that you have made to files since you last added them to the index. This is why I wasn’t getting any results. I had no changes between the index and the working tree.


3.git diff HEAD
	This shows the difference between the files in the working tree and the last commit. There is a gotcha here: if you've made changes, added them to the index, and then backed out these changes in the working tree, you’ll get no results for git diff HEAD (because there is no difference) but you will get output for git diff --cached because there are still changes in the index.


	 
	 */
}
