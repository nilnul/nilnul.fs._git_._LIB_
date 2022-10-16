using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.module.cfg.remote.urls
{
	class Fetch
	{
		/*
		 You can configure multiple remote repos with the git remote command:
git remote add alt alt-machine:/path/to/repo


In order to fetch from all the configured remotes and update tracking branches, but not merge into HEAD, do:
git remote update


If it's not currently connected to one of the remotes, it will time out or throw an error, and go on to the next. You'll have to manually merge from the fetched repos, or cherry-pick, depending on how you want to organize collecting changes.

To fetch the master branch from alt and pull it into your current head, do:
git pull alt master


So in fact git pull is almost shorthand for git pull origin HEAD (actually it looks in the config file to determine this, but you get the idea).

		 */
	}
}
