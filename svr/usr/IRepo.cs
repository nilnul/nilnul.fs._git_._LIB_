namespace nilnul.fs.git.svr.client
{
	/// <summary>
	/// as a git service, the main entity it serves is of course the repo.
	/// but as a server, it has to deal with multiple users, as done in most app, especially webApp.
	/// </summary>
	/// <remarks>
	/// repo is placed under <see cref="svr.IUsr"/> such that no conflicts occur unto repo from different users.
	/// </remarks>
	public interface IRepo { }
}
