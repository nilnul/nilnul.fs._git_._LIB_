namespace nilnul.fs.git.depo._werk_
{
	/// <summary>
	/// either a document, or a symlinked folder.
	/// excluding:
	///		hard directory, which is not symlink, is not managed by werk when it's empty. 
	/// </summary>
	public interface IDossier :destiny_.IExistAtWerk	{ }


}
