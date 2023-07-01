using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._git.git._module.module.cfg
{
	class Submodules
	{
		/*
		 you should notice the new .gitmodules file. This is a configuration file that stores the mapping between the project’s URL and the local subdirectory you’ve pulled it into:
[submodule "DbConnector"]
	path = DbConnector
	url = https://github.com/chaconinc/DbConnector
If you have multiple submodules, you’ll have multiple entries in this file. It’s important to note that this file is version-controlled with your other files, like your .gitignore file. It’s pushed and pulled with the rest of your project. This is how other people who clone this project know where to get the submodule projects from.
		 */

		/*
		 Since the URL in the .gitmodules file is what other people will first try to clone/fetch from, make sure to use a URL that they can access if possible. For example, if you use a different URL to push to than others would to pull from, use the one that others have access to. You can overwrite this value locally with git config submodule.DbConnector.url PRIVATE_URL for your own use. When applicable, a relative URL can be helpful.
		 */


		/*
		 Notice the 160000 mode for the DbConnector entry. That is a special mode in nilnul.win.prog_.Git that basically means you’re recording a commit as a directory entry rather than a subdirectory or a file.
		 */

		/*
		 git clone --recursive https://github.com/chaconinc/MainProject
		 */


		/*
		 git push --recurse-submodules=check

		 */

		/*
		 git push --recurse-submodules=on-demand

		 */

		/*
		 git config alias.sdiff '!'"git diff && git submodule foreach 'git diff'"
$ git config alias.spush 'push --recurse-submodules=on-demand'
$ git config alias.supdate 'submodule update --remote --merge'
		 */
	}
}
