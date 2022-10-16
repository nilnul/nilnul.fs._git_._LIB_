using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage.commit_
{
	/*
	 stackoverflow.com/questions/3592351/how-can-i-specify-custom-global-gitconfig-path
	 

	it wasn't elegant but it did work - and so far seems to be the only way to get this to work.

Git uses the HOME path to determine where .gitconfig is. I was able to perform something like this:

/home/marco/.silly/.gitconfig
/home/marco/.stupid/.gitconfig
/home/marco/.gitconfig
And when executing Git Commit (which is the only command that requires the .gitconfig) I overrode the home path.

HOME=/home/marco/.silly/ git commit -m "silly configuration" 
	 */
	/// <summary>
	///
	/// 
	/// </summary>
	class CfgCustom
	{
	}
}
