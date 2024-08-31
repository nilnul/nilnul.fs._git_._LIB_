namespace nilnul.fs.git.depo._werk_.destiny.be_._ignored._setting
{
	/// <summary>
	///		If there is a separator at the end of the pattern then the pattern will only match directories, otherwise the pattern can match both files and directories.
	///
	/// 
	/// 
	/// If there is a separator at the beginning or middle (or both) of the pattern, then the pattern is relative to the directory level of the particular .gitignore file itself.
	/// For example, a pattern doc/frotz/ matches doc/frotz directory, but not a/doc/frotz directory;
	/// The pattern doc/frotz and /doc/frotz have the same effect in any .gitignore file. In other words, a leading slash is not relevant if there is already a middle slash in the pattern.
	///
	/// Otherwise the pattern may also match at any level below the .gitignore level; this means that with no separator, the pattern matches for any dst at any level.
	/// 
	/// </summary>
	/// alias:
	///		pattern
	///		rule
	///		wildcard
	///		
	interface IPattern{
		/*
		 The pattern hello.* matches any file or directory whose name begins with hello..

		If one wants to restrict this only to the directory and not in its subdirectories, one can prepend the pattern with a slash, i.e. /hello.*; the pattern now matches hello.txt, hello.c but not a/hello.java.

The pattern foo/ will match a directory foo and paths underneath it, but will not match a regular file or a symbolic link foo (this is consistent with the way how pathspec works in general in Git)


		 
		 */

		/*
		 wildcard

The pattern foo/*, matches foo/test.json (a regular file), foo/bar (a directory), but it does not match foo/bar/hello.c (a regular file), as the asterisk in the pattern does not match bar/hello.c which has a slash in it.
		 */

		/*
		 An optional prefix "!" which negates the pattern; any matching file excluded by a previous pattern will become included again. It is not possible to re-include a file if a parent directory of that file is excluded. 
		 */
		/*
		 The range notation, e.g. [a-zA-Z], can be used to match one of the characters in a range.
		 */
	}

}
