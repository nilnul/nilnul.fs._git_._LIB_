using System;

namespace nilnul.fs.git.depo.repo
{
	
	/// <summary>
	/// as log is easily confused with <see cref="refers.ILog"/>, and gitLog is infact not an err0evtLog, but a browsing of histroy, hence we use a different term: <see cref="IHistory"/>
	/// </summary>
	/// alias:
	///		review
	///		revisions
	///		genealogy
	interface IHistory { }

	//[Obsolete(nameof(IReview))]
	//interface ILog { }
}
