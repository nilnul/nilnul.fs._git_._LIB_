using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg
{
	class Credential
	{
		/*
$ git config --global credential.helper cache


Some of these helpers have options. The “store” helper can take a --file <path> argument, which customizes where the plain-text file is saved (the default is ~/.git-credentials). The “cache” helper accepts the --timeout <seconds> option, which changes the amount of time its daemon is kept running (the default is “900”, or 15 minutes). Here’s an example of how you’d configure the “store” helper with a custom file name:


$ git config --global credential.helper 'store --file ~/.my-credentials'


Git even allows you to configure several helpers. When looking for credentials for a particular host, nilnul.win.prog_.Git will query them in order, and stop after the first answer is provided. When saving credentials, nilnul.win.prog_.Git will send the username and password to all of the helpers in the list, and they can choose what to do with them. Here’s what a .gitconfig would look like if you had a credentials file on a thumb drive, but wanted to use the in-memory cache to save some typing if the drive isn’t plugged in:


[credential]
    helper = store --file /mnt/thumbdrive/.git-credentials
    helper = cache --timeout 30000
*/

		/* git config --list  and looking for  credential.helper=manager */
	}
}
