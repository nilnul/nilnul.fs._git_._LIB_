using nilnul.fs.git.depo;
using System;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// including both repo and stage
	/// </summary>
	/// and also stash?
	/// alias:
	///		shelf
	///			stash, including stage and work
	///		storage
	///		nonwork
	///		antiwork
	///		workless
	///		Head9stage
	///		Snap9stage
	///		rack
	///		
	///		
	///	vs: <see cref="State"/> which includes repo,stage and work, whileas this excludes work.
	///	<seealso cref="fs.git._depo_.IRepo9stage"/>
	///
	[Obsolete(nameof(IRack))]
	public interface IShelf:IRack { }
}
