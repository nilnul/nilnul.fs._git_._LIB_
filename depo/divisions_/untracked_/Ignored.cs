using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.divisions_.untracked_
{
	/// <summary>
	/// determined by:
	///		0) untracked in stage. if a file is tracked in stage, it will not be ignored, disregarding the following rules.
	/// 
	///		1) .ignore files in the directory hierarchy from current directory to the base of the depo
	///		2) exclude file in .git/info
	///		3) global|osUsr .gitignore file:
	///			~/. config/git/ignore on Unix/macOS and %USERPROFILE%\git\ignore on Windows
	///			, you can define global Git ignore patterns for all repositories on your local system by setting the Git core.excludesFile property, eg:
	///				git config --global core.excludesFile ~/.gitignore
	/// </summary>
	internal class Ignored
	{
	}
}
