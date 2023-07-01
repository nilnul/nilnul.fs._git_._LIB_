namespace nilnul.fs.git
{
	/// repo means the shared part; so it excludes <see cref="module.IStaged"/>;
	/// depo includes commits, but also staged index;
	/// 
	/// <summary>
	/// module or bareRepo.
	/// depot(receive and dispense|depart|dispatch) or depository(only receive)
	/// depot, dispatched repo, depository, 
	/// </summary>
	public interface IDepo:IModule0BareRepo {

	}


}
