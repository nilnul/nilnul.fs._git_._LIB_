using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.remote.push
{
	/// <summary>
	/// push a commit to remote
	/// </summary>
	/// <remarks>
	/*  First you need to get the hash of the commit you want to push by using the command “git log” (Press “q” to exit the log).  A hash is a 40 character alpha-numeric string that looks something like  2dc2b7e393e6b712ef103eaac81050b9693395a4 .  Once you have the correct hash, use the push command as you normally would, except provide the hash as part of the command:

$ git push<remote name> <commit hash>:<remote branch name>

# Example:
$ git push origin 2dc2b7e393e6b712ef103eaac81050b9693395a4:master

 $ git push <remote name> <commit hash>:<remote branch name>
 
# Example:
$ git push origin 2dc2b7e393e6b712ef103eaac81050b9693395a4:master

Important Note: This will push all commits up to and including the specified commit!  This means if you specify the commit that is at the top of your branch it will push everything, exactly the same as a regular push.You need to reorder your commits first to make sure the commit you want to push is at the bottom (directly above the remote branch).  How to reorder commits with nilnul.win.prog_.Git.

In place of the hash, you can also use standard nilnul.win.prog_.Git revision names such as HEAD~1 or HEAD^, as well as abbreviated hash names.

	*/
	///</remarks>
	public class Commit
	{

	}
}
