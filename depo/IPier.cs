namespace nilnul.fs.git.depo
{
	/*
Mercurial, which is very similar to Git in many ways, has no staging area—you just run hg commit and it commits whatever is in the work-tree.3 The work-tree is your staging-area: you just edit and go.
	(you can still ignore files, or select what to commit);
	Git actually lets you get most of the same effect by using git commit -a
	 
Whether the index / staging-area is a good idea is a matter of opinion, but because Git has it and uses it extensively, it's important to know that Git has it.
	
	 staging helps when a merge has conflicts
	 */

	/*This tree is a complex internal caching mechanism. Git generally tries to hide the implementation details of the Staging Index from the user.
	To accurately view the state of the Staging Index we must utilize a lesser known Git command git ls-files. The git ls-files command is essentially a debug utility for inspecting the state of the Staging Index tree. 
	 */
	/*https://github.com/git/git/blob/master/Documentation/technical/index-format.txt
	 
		index file is not expected in bare repo.
	 
		 */
	/*
	 The index is a binary file (generally kept in .git/index) containing a sorted list of path names, each with permissions and the SHA1 of a blob object; git ls-files can show you the contents of the index


	The index contains all the information necessary to generate a single (uniquely determined) tree object.
	 */

	/// <summary>
	/// including: index .
	/// what is committed is from the index rather than the working tree
	/// </summary>
	/// <remarks>
	/// The "index" holds a snapshot of the content of the working tree, and it is this snapshot that is taken as the contents of the next commit.
	/// </remarks>
	///vs:
	///		<see cref="IRack"/>, that and this both takes repo as related, but for rack, both can change, whileas for this, only pier can change. 
	/// 
	/// <see cref="repo.IIndex"/>
	/// alias:
	///		stage
	///		cache
	///		staged
	///			like state,
	///			such as to differ from <see cref="repo.IIndex"/>
	///		index
	///
	public interface IPier
	{

		/*
	The index always contains the IDs of the blobs of the files in HEAD, plus a bunch of flags to track changes to the files. It does not contain a snapshot of the last commit
		
The index (.git/index) always stores a list of the blob IDs and filepaths of all the files in HEAD, plus metadata about the files (permissions, modification times, owners, etc...).


The index can also contain pre-computed tree objects (how Git stores directories) to speed up committing. It also stores information about conflicts.

So an "empty" index contains a list of all the filepaths, their blob IDs, meta information about the files, and space to store conflict information. Because it only stores the blob IDs (160 bits) the index avoids being redundant with HEAD. Index files for my projects are anywhere from less than 1K to 500K for large projects like Perl and Git.
		 */
	}
}
