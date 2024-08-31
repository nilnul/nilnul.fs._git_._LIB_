using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.divisions_.untracked_._ignored.patterns
{
	///atlassian.com/git/tutorials/saving-changes/gitignore
	/// <summary>
	/// If you have complicated .gitignore patterns, or patterns spread over multiple .gitignore files, it can be difficult to track down why a particular file is being ignored. You can use the git check-ignore command with the -v (or --verbose) option to determine which pattern is causing a particular file to be ignored:
	/// $ git check-ignore -v debug.log
	/// .gitignore:3:*.log  debug.log
	/// The output shows:
	/// {file containing the pattern} : {line number of the pattern} : {pattern}    {file name}
	/// You can pass multiple file names to git check-ignore if you like, and the names themselves don't even have to correspond to files that exist in your repository.
	/// </summary>
	internal class OnPath
	{
		/*
		 
		 */
	}
}
