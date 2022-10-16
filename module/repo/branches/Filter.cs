using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	/*For the huge repositories that have lots of binary cruft committed by mistake, or old assets not needed anymore, a great solution is to use git filter-branch. The command lets you walk through the entire history of the project filtering out, modifying, and skipping files according to predefined patterns.

It is a very powerful tool once you’ve identified where your repo is heavy. There are helper scripts available to identify big objects, so that part should be easy enough.
 The syntax goes like this:
git filter-branch --tree-filter 'rm -rf [/path/to/spurious/asset/folder]' HEAD

git filter-branch has a minor drawback, though: once you use _filter-branch_, you effectively rewrite the entire history of your project. That is, all commit ids change. This requires every developer to re-clone the updated repository.

So if you’re planning to carry out a cleanup action using git filter-branch, you should alert your team, plan a short freeze while the operation is carried out, and then notify everyone that they should clone the repository again.
*/
	static  class _FilterX
	{

	}
}
