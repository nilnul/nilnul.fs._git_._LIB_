using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.tag.push_
{
	///git-scm.com/docs/git-push
	///
	/// tag <tag> means the same as refs/tags/<tag>:refs/tags/<tag>
	///
	/// 
	/// <summary>
	/// If your tag is the same as remote branch and git push fails with error:
	/// src refspec <tag_name> matches more than one.
	/// , you can push it as:
	/// git push origin tag <tag_name>
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	internal class Namesake2branch
	{
	}
}
