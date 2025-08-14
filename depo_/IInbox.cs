using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo_
{
	///
	/// <summary>
	/// this is where incomeing files are interimly stored for later moving out to a permanent repo.
	///
	/// The branches are not utilized. the history is not utilized. Only current revision, restored as werk, is meaningful. We may add or remove some files from current werk, which would be synchronized with the current revision.
	/// </summary>
	/// <remarks>
	/// To save storage space, the werk might be removed altogether, only leaving some .nilnul files behind; but the werk still is yet to be moved to permanent storage space. To differentiate from the case when files are moved out of box to a permanent, we can tell by:
	///		, according to the revision, when the files are removed but the removal is not commited, then the removal is just for saving space interimly, not a relocating to a permanent space.
	///		, reading .nilnul
	///		, reading the commit message.
	/// </remarks>
	/// 
	/// alias:
	///		shallow
	///			,only the surface is useful, anything under surface is just disregarded.
	public interface IInbox:fs.git.IDepo
	{
	}
}
