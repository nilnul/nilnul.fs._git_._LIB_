using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.remote.current
{
	/*
git update-ref -d refs/remotes/origin/HEAD will remove both refs/remotes/origin/HEAD and refs/remotes/origin/.
	To remove only HEAD you can use
	git remote set-head origin --delete

Delete the ref refs/remotes/origin/HEAD:

git remote set-head origin -d
	*/
	internal class Drop
	{
	}
}
