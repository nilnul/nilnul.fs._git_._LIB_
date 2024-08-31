using System;

namespace nilnul.fs.git.depo._pier_.dossiers_.xpn_
{
	/// <summary>
	/// if a file is deleted from stage, it's not regarded as a file in stage, and hence here we are not talking about that.
	/// we are here talking about a file *staged* for delete.
	/// not care about whether it's deleted from werk. if it's deleted from werk, the the deletion is staged. if it's not deleted from werk (you can restore the file after deleting it from <see cref="depo.stow"/>), then the deletion is staged, leaving the file in werk untracked, and you will see two entries for the same in <see cref="dossiers_.cutoff_.still8werk_._ByStatusX"/>
	/// </summary>
	/// <remarks>
	/// the devoid is relative to the head. 
	/// </remarks>
	/// alias:
	///		devoid
	///		demote
	///		demolish
	///		oust
	///		void
	///		nullified
	///		deprived
	///		destitute
	///		deject
	///		reject
	///		vacant
	///		purgable
	///		coverable
	///		abandoned
	///		squash
	///		discard
	///		trash
	///		
	///		cutoff
	///		dismiss
	///		discontinue
	///		cull
	///		break
	///		Marked4deletion
	///
	[Obsolete(nameof(destinys_.IUntracked))]
	interface IDevoid { }

}
