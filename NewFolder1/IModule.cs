using System;

namespace nilnul.fs.git
{
	/// <summary>
	/// including
	///		the work (including all contents), the repo (and all contents) which is not bare
	///		the relation between the two
	/// Vs_.folder_.git_.top:
	///		Top refers to only the top
	///			module refers to the top and the contents.
	/// </summary>
	/// alias:
	///		depo
	///			,depository, like repository
	///		managed,<see cref="IManaged"/>
	///

	[Obsolete(nameof(IDepo))]
	public interface IModule:
		IManaged{

	}
}
