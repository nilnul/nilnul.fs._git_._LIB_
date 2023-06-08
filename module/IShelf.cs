﻿namespace nilnul.fs.git.module
{
	/// <summary>
	/// including both repo and stage
	/// </summary>
	/// alias:
	///		shelf
	///			stash, including stage and work
	///		nonwork
	///		antiwork
	///		workless
	///		
	///	vs: <see cref="IStatue"/> which includes repo,stage and work, this excludes repo.
	public interface IShelf { }
}
