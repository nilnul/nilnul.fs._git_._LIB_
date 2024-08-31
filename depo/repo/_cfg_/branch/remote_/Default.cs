using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.branch.remote_
{
	/* 
	Track the remote branch
	You can specify the default remote repository for pushing and pulling using git-branch’s track option.You’d normally do this by specifying the --track option when creating your local master branch, but as it already exists we’ll just update the config manually like so:
   Edit your .git/config
   [branch "master"]
	 remote = origin
	 merge = refs / heads / master
   Now you can simply git push and git pull.
   */
	/// <summary>
	/// </summary>
	public class Default
	{

	}
}
