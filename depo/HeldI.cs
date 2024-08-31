using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo
{
	/// <summary>
	/// the HEAD in .git folder. This points to the current tip being worked at. The tip is generally a branch (called ,hence ,current branch) or a commit (the head is now described as "detached")
	/// </summary>
	/// <remarks>
	/// generally, head is an indirection to branch, which is again an indirection to commit;
	/// in some special case, head can be indiction to commmit;
	/// in all, head is an indirection to commit, where the indirection can be one step or two steps;
	/// </remarks>
	///alias:
	///		dome
	///		peak
	///		
	///		apex
	///		head, which is used by <see cref="depo.repo.head"/>
	///
	///		grip
	///		hold
	///			,which is similar to head, and held, the past tence is more similar;
	///		knob
	///	vs:
	///		<see cref="depo.repo.branch_.ICurrent"/>
	public interface IHeld { }
	public interface HeldI
	{
	}
}
