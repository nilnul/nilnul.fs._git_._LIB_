using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.tag
{
	/// git push origin <tag_name> not worked. git push origin refs/tags/<tag_name>works.
	/// <summary>
	/// git push origin {tag_name}
	/// </summary>
	/// <remarks>
	/// git push --tags origin <tag_name> IS NOT what you want- despite naming a specific tag, it pushes them all, even lightweight ones. 
	/// </remarks>
	/// bibliography:
	///		stackoverflow.com/questions/5195859/how-do-you-push-a-tag-to-a-remote-repository-using-git
	///			nealmcb
	class IPush
	{


	}
}
