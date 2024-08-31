namespace nilnul.fs.git.depo.pier.vs_
{
	/// <summary>
	/// git diff [<options>] --cached [--merge-base] [<commit>] [--] [<path>…​]
	/// This form is to view the changes you staged for the next commit relative to the named<commit>.Typically you would want comparison with the latest commit, so if you do not give<commit>, it defaults to HEAD. If HEAD does not exist (e.g.unborn branches) and <commit> is not given, it shows all staged changes. --staged is a synonym of --cached.
	/// </summary>
	interface VsSnap { }
}
