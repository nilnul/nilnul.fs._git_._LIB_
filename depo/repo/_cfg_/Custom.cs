using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_
{
	/*If you have a look inside .git/config you’ll see that data is structured in key-value pairs grouped in to sections.

[branch "master"]
	remote = origin
	merge = refs/heads/master


Which is accessed by running a command like this…

-> git config branch.master.remote
origin


And modified like this…
-> git config branch.master.remote newValue

You can define a new section to store your own data like this…

-> git config mydata.mykey valueA
You can store multiple values too…

-> git config --add mydata.mykey valueB
And fetch them all like this…

-> git config --get-all mydata.mykey
valueA
valueB
Delete a single value like this…

-> git config --unset mydata.mykey valueB
Delete all key values like this…

-> git config --unset-all mydata.mykey


And to remove a whole section…

-> git config --remove-section mydata*/


	/*
--global
For writing options: write to global ~/.gitconfig file rather than the repository .git/config, write to $XDG_CONFIG_HOME/git/config file if this file exists and the ~/.gitconfig file doesn’t.

For reading options: read only from global ~/.gitconfig and from $XDG_CONFIG_HOME/git/config rather than from all available files.

See also FILES.

--system
For writing options: write to system-wide $(prefix)/etc/gitconfig rather than the repository .git/config.

For reading options: read only from system-wide $(prefix)/etc/gitconfig rather than from all available files.

See also FILES.

--local
For writing options: write to the repository .git/config file. This is	the default behavior.

For reading options: read only from the repository .git/config rather than from all available files.

See also FILES.*/

	/*lso, avoid _'s in the custom field name. nilnul.win.prog_.Git doesn't parse them:

$ git config user.custom_field test
error: invalid key: user.custom_field*/
	public class Custom
	{
	}
}
