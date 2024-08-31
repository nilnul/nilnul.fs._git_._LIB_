namespace nilnul.fs.git
{
	/// repo means the shared part; so it excludes <see cref="module.IStaged"/>;
	/// depo includes commits, but also staged index;
	/// 
	/// 
	/// <summary>
	/// usually a folder with a ".git/" in it; This is where you generally works, including: worktree together with the repo.
	/// </summary>
	/// <remarks>
	///excluding:
	///		any subdepo in it.
	///	to include subdepo, <see cref="nilnul.fs.folder_.git_.Top"/>
	/// </remarks>
	/// alias:
	///		module
	/// depot(receive and dispense|depart|dispatch) or depository(only receive)
	/// depot, dispatched repo, depository, 
	///		
	///		
	public interface IDepo
		:
		//IModule0BareRepo
		nilnul.fs.IFolder
	{

	}


}
