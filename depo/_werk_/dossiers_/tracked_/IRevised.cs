using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._werk_.dossiers_.tracked_
{
	///
	/// <summary>
	/// it's tracked, exist.  excluding:
	///		-deleted, as it's not dossiers,
	///		- new<see cref="revised_.xpn_.INew"/>, as it's not tracked.
	///	so this is in fact <see cref="dossiers_.tracked_.IAltered"/>
	/// 
	/// </summary>
	///<remarks>
	/// based on <see cref="pier"/>; comparision between:
	///		the stage (not the HEAD), the werk.
	///
	/// </remarks>
	/// 
	///	 vs: <see cref="git.depo._stow_.dossiers_.IChanged"/> when we need to consider HEAD  shoulder2shoulder;
	/// 
	/// alias:
	///		revised
	///			,use a past tense, as this is a comparison describing sth that has happened;
	///		modified, as git uses it
	///		revise
	///			,means vs pier
	///		review
	///		
	///		delta
	///		compare5pier
	///		
	///		change, <see cref="nilnul.data.store_.monolith.rite_.IChange"/>
	///			,but here we only compare it with the cached entry. hence it's some misleading.
	///		revision
	///		drift
	///		moor
	///		adjusted
	/// vs:
	///		<see cref="ITracked"/>
	interface IRevised:ITracked
	{


	}

}
