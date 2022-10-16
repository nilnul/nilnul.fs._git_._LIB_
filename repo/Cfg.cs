using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo
{
	/*
	 *Git comes with a tool called git config that lets you get and set configuration variables that control all aspects of how Git looks and operates. These variables can be stored in three different places:
	 * 
/etc/gitconfig file: Contains values for every user on the system and all their repositories. If you pass the option --system to git config, it reads and writes from this file specifically.

~/.gitconfig file: Specific to your user. You can make Git read and write to this file specifically by passing the --global option.

config file in the git directory (that is, .git/config) of whatever repository you’re currently using: Specific to that single repository. Each level overrides values in the previous level, so values in .git/config trump those in /etc/gitconfig.
*/
	class Cfg
	{
	}
}
